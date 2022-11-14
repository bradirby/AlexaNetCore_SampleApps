using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MultiturnDialog.Tests.TestData;


namespace AlexaNetCore.ZeroToHero.MultiturnDialog.Tests;

public class CancelRequestTests 
{

    [Test]
    public async Task SetsSpokenText()
    {
        var skill = new MultiturnDialogSkill(new LoggerFactory());
        skill.LoadRequest(BuiltInIntentQueries.CancelRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual("OK, Cancelling", skill.GetSpokenText());
    }

    [Test]
    public async Task HasNoRepromptText()
    {
        var skill = new MultiturnDialogSkill(new LoggerFactory());
        skill.LoadRequest(BuiltInIntentQueries.CancelRequest);
        await skill.ProcessRequestAsync();
        
        Assert.IsTrue(string.IsNullOrWhiteSpace(skill.GetRepromptText()));
    }

    [Test]
    public async Task ClosesSession()
    {
        var skill = new MultiturnDialogSkill(new LoggerFactory());
        skill.LoadRequest(BuiltInIntentQueries.CancelRequest);
        await skill.ProcessRequestAsync();
        
        Assert.AreEqual(true, skill.ShouldEndSession);
    }


}