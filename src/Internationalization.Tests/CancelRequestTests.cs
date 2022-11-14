using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore.Model;
using Internationalization.Tests;
using Microsoft.Extensions.Logging;

namespace AlexaNetCore.ZeroToHero.Internationalization.Tests;

public class CancelRequestTests 
{

   [Test]
    public async Task DefaultLanguage_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .LoadRequest(IntlSampleQueries.CancelIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("Goodbye", skill.GetSpokenText());
    }


    [Test]
    public async Task SpecifyItalian_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .RegisterRequestInterceptor(new SetBaseRequestLanguageDebugInterceptor(AlexaLocale.Italian))
            .LoadRequest(IntlSampleQueries.CancelIntent)
            .ProcessRequestAsync();

        Assert.AreEqual("Arrivederci", skill.GetSpokenText());
    }


    



    [Test]
    public async Task DefaultLanguage_SetsRepromptText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .LoadRequest(IntlSampleQueries.CancelIntent)
            .ProcessRequestAsync();

        Assert.IsTrue(string.IsNullOrEmpty( skill.GetRepromptText()));
    }


    [Test]
    public async Task SpecifyItalian_SetsRepromptText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .RegisterRequestInterceptor(new SetBaseRequestLanguageDebugInterceptor(AlexaLocale.Italian))
            .LoadRequest(IntlSampleQueries.CancelIntent)
            .ProcessRequestAsync();
        Assert.IsTrue(string.IsNullOrEmpty( skill.GetRepromptText()));
    }
    
    
    
    
    
    
    
    [Test]
    public async Task KeepsSessionOpen()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .LoadRequest(IntlSampleQueries.CancelIntent)
            .ProcessRequestAsync();
        Assert.AreEqual(true, skill.ShouldEndSession);
    }

}