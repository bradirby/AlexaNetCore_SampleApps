using System.Threading.Tasks;
using NUnit.Framework;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.MultiturnDialog.Tests;

public class HelpRequestTests 
{
    [Test]
    public async Task SetsSpokenText()
    {
        var skill = new MultiturnDialogSkill();
        skill.LoadRequest(BuiltInIntentQueries.HelpRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual("You can say 'Tell Me Hello' or 'i want to hear you say hello'.  Give it a try", 
            skill.GetSpokenText());
    }

   

    [Test]
    public async Task KeepsSessionOpen()
    {
        var skill = new MultiturnDialogSkill();
        skill.LoadRequest(BuiltInIntentQueries.HelpRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual(false, skill.ShouldEndSession);
    }



}