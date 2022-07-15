using System.Threading.Tasks;
using NUnit.Framework;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.HelloWorld.Tests;

public class HelpRequestTests 
{
    [Test]
    public async Task SetsSpokenText()
    {
        var skill = new HelloWorldSkill();
        skill.LoadRequest(HelloWorldSampleQueries.HelpIntent);
        await skill.ProcessRequestAsync();

        Assert.AreEqual("You can say 'How old is Dot Net Core' or 'When was Dot Net born'.  Give it a try", 
            skill.GetSpokenText());
    }

   

    [Test]
    public async Task KeepsSessionOpen()
    {
        var skill = new HelloWorldSkill();
        skill.LoadRequest(HelloWorldSampleQueries.HelpIntent);
        await skill.ProcessRequestAsync();

        Assert.AreEqual(false, skill.ShouldEndSession);
    }



}