using System.Threading.Tasks;
using AlexaNetCore;
using AlexaNetCore.Model;
using NUnit.Framework;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.Internationalization.Tests;

public class StopRequestTests 
{

   [Test]
    public async Task DefaultLanguage_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill()
            .LoadRequest(BuiltInIntentQueries.StopRequest)
            .ProcessRequestAsync();
        Assert.AreEqual("Goodbye", skill.GetSpokenText());
    }


    [Test]
    public async Task SpecifyItalian_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill()
            .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Italian), 1000)
            .LoadRequest(BuiltInIntentQueries.StopRequest)
            .ProcessRequestAsync();
        Assert.AreEqual("Arrivederci", 
            skill.GetSpokenText());
    }

    [Test]
    public async Task SpecifySpanish_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill()
            .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Spanish_ES), 1000)
            .LoadRequest(BuiltInIntentQueries.StopRequest)
            .ProcessRequestAsync();
        Assert.AreEqual("Adiós", 
            skill.GetSpokenText());
    }

    



    [Test]
    public async Task DefaultLanguage_SetsRepromptText()
    {
        var skill = await new InternationalizationSkill()
            .LoadRequest(BuiltInIntentQueries.StopRequest)
            .ProcessRequestAsync();
        Assert.IsTrue(string.IsNullOrEmpty( skill.GetRepromptText()));
    }


    [Test]
    public async Task SpecifyItalian_SetsRepromptText()
    {
        var skill = await new InternationalizationSkill()
            .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Italian), 1000)
            .LoadRequest(BuiltInIntentQueries.StopRequest)
            .ProcessRequestAsync();
        Assert.IsTrue(string.IsNullOrEmpty( skill.GetRepromptText()));
    }
    
    
    
    
    
    
    
    [Test]
    public async Task KeepsSessionOpen()
    {
        var skill = await new InternationalizationSkill()
            .LoadRequest(BuiltInIntentQueries.StopRequest)
            .ProcessRequestAsync();
        Assert.AreEqual(true, skill.ShouldEndSession);
    }

}