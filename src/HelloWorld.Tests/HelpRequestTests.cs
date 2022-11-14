using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace AlexaNetCore.ZeroToHero.HelloWorld.Tests;

public class HelpRequestTests 
{
    [Test]
    public async Task SetsSpokenText()
    {
        var skill = new HelloWorldSkill(new LoggerFactory());
        skill.LoadRequest(HelloWorldSampleQueries.HelpIntent);
        await skill.ProcessRequestAsync();

        Assert.AreEqual("You can say 'How old is Dot Net Core' or 'When was Dot Net born'.  Give it a try", 
            skill.GetSpokenText());
    }

   

    [Test]
    public async Task KeepsSessionOpen()
    {
        var skill = new HelloWorldSkill(new LoggerFactory());
        skill.LoadRequest(HelloWorldSampleQueries.HelpIntent);
        await skill.ProcessRequestAsync();

        Assert.AreEqual(false, skill.ShouldEndSession);
    }



}