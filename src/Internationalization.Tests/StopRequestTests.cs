using System.Threading.Tasks;
using AlexaNetCore.Model;
using Internationalization.Tests;
using NUnit.Framework;

namespace AlexaNetCore.ZeroToHero.Internationalization.Tests;

public class StopRequestTests 
{

   [Test]
    public async Task DefaultLanguage_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill()
            .LoadRequest(IntlSampleQueries.StopIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("Goodbye", skill.GetSpokenText());
    }


    [Test]
    public async Task SpecifyItalian_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill()
            .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Italian), 1000)
            .LoadRequest(IntlSampleQueries.StopIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("Arrivederci", 
            skill.GetSpokenText());
    }

    [Test]
    public async Task SpecifySpanish_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill()
            .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Spanish_ES), 1000)
            .LoadRequest(IntlSampleQueries.StopIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("Adiós", 
            skill.GetSpokenText());
    }

    



    [Test]
    public async Task DefaultLanguage_SetsRepromptText()
    {
        var skill = await new InternationalizationSkill()
            .LoadRequest(IntlSampleQueries.StopIntent)
            .ProcessRequestAsync();
        Assert.IsTrue(string.IsNullOrEmpty( skill.GetRepromptText()));
    }


    [Test]
    public async Task SpecifyItalian_SetsRepromptText()
    {
        var skill = await new InternationalizationSkill()
            .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Italian), 1000)
            .LoadRequest(IntlSampleQueries.StopIntent)
            .ProcessRequestAsync();
        Assert.IsTrue(string.IsNullOrEmpty( skill.GetRepromptText()));
    }
    
    
    
    
    
    
    
    [Test]
    public async Task KeepsSessionOpen()
    {
        var skill = await new InternationalizationSkill()
            .LoadRequest(IntlSampleQueries.StopIntent)
            .ProcessRequestAsync();
        Assert.AreEqual(true, skill.ShouldEndSession);
    }

}