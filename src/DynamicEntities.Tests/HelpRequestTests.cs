using System.Threading.Tasks;
using NUnit.Framework;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.DynamicEntities.Tests;

public class HelpRequestTests 
{
    [Test]
    public async Task SetsSpokenText()
    {
        var skill = new DynamicEntitySkill();
        skill.LoadRequest(BuiltInIntentQueries.HelpRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual("Tell me the state you live in, then you can select a county", 
            skill.GetSpokenText());
    }

   

    [Test]
    public async Task KeepsSessionOpen()
    {
        var skill = new DynamicEntitySkill();
        skill.LoadRequest(BuiltInIntentQueries.HelpRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual(false, skill.ShouldEndSession);
    }



}