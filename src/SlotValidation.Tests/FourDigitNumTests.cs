using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using SlotValidation.SupportingFiles;
using SlotValidation.Tests.TestData;

namespace SlotValidation.Tests;

public class FourDigitNumTests
{
    [Test]
    public async Task SingleValue_NoValidation_NoDataSpecified()
    {
        var skill = new SlotValidationSkill(new LoggerFactory());
        skill.LoadRequest(FourDigitNumQueries.SingleYear_NoValidation_NoDataSpecified);
        await skill.ProcessRequestAsync();

        var s = skill.ChosenIntent.GetAlexaSlot(SkillConstants.SlotNames.FourDigitNumSlotName);
        Assert.IsNotNull(s);
        Assert.IsFalse(s.ContainsMultipleValues);

        Assert.AreEqual(null, s.Value);
    }


    [Test]
    public async Task SingleValue_NoValidation_ReturnsSlotValue()
    {
        var skill = new SlotValidationSkill(new LoggerFactory());
        skill.LoadRequest(FourDigitNumQueries.IWasBornIn1950_SingleValue_NoValidation);
        await skill.ProcessRequestAsync();

        var s = skill.ChosenIntent.GetAlexaSlot(SkillConstants.SlotNames.FourDigitNumSlotName);
        Assert.IsNotNull(s);
        Assert.IsFalse(s.ContainsMultipleValues);

        Assert.AreEqual("1950", s.Value);
    }


    [Test]
    public async Task SingleValue_WithValidation_ReturnsSlotValue()
    {
        var skill = new SlotValidationSkill(new LoggerFactory());
        skill.LoadRequest(FourDigitNumQueries.IWasBornIn1950_SingleValue_WithValidation);
        await skill.ProcessRequestAsync();

        var s = skill.ChosenIntent.GetAlexaSlot(SkillConstants.SlotNames.FourDigitNumSlotName);
        Assert.IsFalse(s.ContainsMultipleValues);
        Assert.IsNotNull(s);

        Assert.AreEqual("1950", s.Value);

    }

    [Test]
    public async Task MultiYear_NoValidation_ReturnsSlotValue()
    {
        var skill = new SlotValidationSkill(new LoggerFactory());
        skill.LoadRequest(FourDigitNumQueries.MultipleValues_NoValidation);
        await skill.ProcessRequestAsync();

        var s = skill.ChosenIntent.GetAlexaSlot(SkillConstants.SlotNames.FourDigitNumSlotName);
        Assert.IsTrue(s.ContainsMultipleValues);
        Assert.IsNotNull(s);

        Assert.IsNull( s.Value);

        Assert.AreEqual("1950", s.Values.First());
        Assert.AreEqual("1960", s.Values.Last());

    }

    [Test]
    [Ignore("Cannot get the dev console to accept my utterance so can't get a query to use for this test")]
    public async Task MultiYear_WithValidation_ReturnsSlotValue()
    {
        var skill = new SlotValidationSkill(new LoggerFactory());
        skill.LoadRequest(FourDigitNumQueries.MultipleValues_WithValidation);
        await skill.ProcessRequestAsync();

        var s = skill.ChosenIntent.GetAlexaSlot(SkillConstants.SlotNames.FourDigitNumSlotName);
        Assert.IsTrue(s.ContainsMultipleValues);
        Assert.IsNotNull(s);

        Assert.IsNull(s.Value);

        Assert.AreEqual("1950", s.Values.First());
        Assert.AreEqual("1960", s.Values.Last());

    }

}