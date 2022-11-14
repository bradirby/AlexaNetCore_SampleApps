using System.Threading.Tasks;
using NUnit.Framework;
using MultiturnDialog.Tests.TestData;
using Microsoft.Extensions.Logging;

namespace AlexaNetCore.ZeroToHero.MultiturnDialog.Tests;

public class HelpRequestTests 
{
    [Test]
    public async Task SetsSpokenText()
    {
        var skill = new MultiturnDialogSkill(new LoggerFactory());
        skill.LoadRequest(BuiltInIntentQueries.HelpRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual("You can say 'Tell Me Hello' or 'i want to hear you say hello'.  Give it a try", 
            skill.GetSpokenText());
    }

   

    [Test]
    public async Task KeepsSessionOpen()
    {
        var skill = new MultiturnDialogSkill(new LoggerFactory());
        skill.LoadRequest(BuiltInIntentQueries.HelpRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual(false, skill.ShouldEndSession);
    }



}