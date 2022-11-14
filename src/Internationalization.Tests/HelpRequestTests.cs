using AlexaNetCore;
using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore.Model;
using Internationalization.Tests;
using Microsoft.Extensions.Logging;

namespace AlexaNetCore.ZeroToHero.Internationalization.Tests;

public class HelpRequestTests 
{
    [Test]
    public async Task DefaultLanguage_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .LoadRequest(IntlSampleQueries.HelpIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("You can say 'what languages are you trained with'", skill.GetSpokenText());
    }


    [Test]
    public async Task SpecifyItalian_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .RegisterRequestInterceptor(new SetBaseRequestLanguageDebugInterceptor(AlexaLocale.Italian))
            .LoadRequest(IntlSampleQueries.HelpIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("Puoi dire 'in quali lingue ti sei formato'?", skill.GetSpokenText());
    }


    [Test]
    public async Task SpecifySpanish_SetsSpokenText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .RegisterRequestInterceptor(new SetBaseRequestLanguageDebugInterceptor(AlexaLocale.Spanish_ES))
            .LoadRequest(IntlSampleQueries.HelpIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("Puedes decir 'en qué idiomas estás entrenado'?", skill.GetSpokenText());
    }

    



    [Test]
    public async Task DefaultLanguage_SetsRepromptText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .LoadRequest(IntlSampleQueries.HelpIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("Did you need some more time?", skill.GetRepromptText());
    }


    [Test]
    public async Task SpecifyItalian_SetsRepromptText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .RegisterRequestInterceptor(new SetBaseRequestLanguageDebugInterceptor(AlexaLocale.Italian))
            .LoadRequest(IntlSampleQueries.HelpIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("Avevi bisogno di un po' più di tempo?", skill.GetRepromptText());
    }
    
    
    [Test]
    public async Task SpecifySpanish_SetsRepromptText()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .RegisterRequestInterceptor(new SetBaseRequestLanguageDebugInterceptor(AlexaLocale.Spanish_ES))
            .LoadRequest(IntlSampleQueries.HelpIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("Necesitabas más tiempo?", skill.GetRepromptText());
    }


    
    
    
    
    
    [Test]
    public async Task KeepsSessionOpen()
    {
        var skill = await new InternationalizationSkill(new LoggerFactory())
            .LoadRequest(IntlSampleQueries.HelpIntent)
            .ProcessRequestAsync();
        Assert.AreEqual(false, skill.ShouldEndSession);
    }

}