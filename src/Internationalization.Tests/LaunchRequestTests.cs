﻿using System.Threading.Tasks;
using AlexaNetCore.Model;
using Internationalization.Tests;
using NUnit.Framework;

namespace AlexaNetCore.ZeroToHero.Internationalization.Tests
{
    public class LaunchRequestTests
    {

        [Test]
        public async Task DefaultLanguage_ReturnsProperTextString()
        {
            var skill = await new InternationalizationSkill()
                .LoadRequest(IntlSampleQueries.LaunchRequest)
                .ProcessRequestAsync();
            Assert.AreEqual("Welcome, say 'what languages are you trained with'.",
                skill.GetSpokenText());
        }


        [Test]
        public async Task SpecifyItalian_ReturnsProperTextString()
        {
            var skill = await new InternationalizationSkill()
                .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Italian), 1000)
                .LoadRequest(IntlSampleQueries.LaunchRequest)
                .ProcessRequestAsync();

            Assert.AreEqual("Benvenuto, dì 'in quali lingue ti sei formato'?",
                skill.GetSpokenText());
        }

        [Test]
        public async Task SpecifySpanish_ReturnsProperTextString()
        {
            var skill = await new InternationalizationSkill()
                .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Spanish_ES), 1000)
                .LoadRequest(IntlSampleQueries.LaunchRequest)
                .ProcessRequestAsync();

            Assert.AreEqual("Bienvenido, diga 'en qué idiomas está entrenado'?",
                skill.GetSpokenText());
        }




        [Test]
        public async Task DefaultLanguage_SetsRepromptText()
        {
            var skill = await new InternationalizationSkill()
                .LoadRequest(IntlSampleQueries.LaunchRequest)
                .ProcessRequestAsync();
            Assert.AreEqual("Did you need some help?", skill.GetRepromptText());
        }

 
        [Test]
        public async Task SpecifyItalian_SetsRepromptText()
        {
            var skill = await new InternationalizationSkill()
                .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Italian), 1000)
                .LoadRequest(IntlSampleQueries.LaunchRequest)
                .ProcessRequestAsync();

            Assert.AreEqual("Avevi bisogno di aiuto?", skill.GetRepromptText());
        }
        
        [Test]
        public async Task SpecifySpanish_SetsRepromptText()
        {
            var skill = await new InternationalizationSkill()
                .RegisterRequestInterceptor(new SetRequestLanguageDebugInterceptor(AlexaLocale.Spanish_ES), 1000)
                .LoadRequest(IntlSampleQueries.LaunchRequest)
                .ProcessRequestAsync();

            Assert.AreEqual("Necesitabas ayuda?", skill.GetRepromptText());
        }
        


        
        
        [Test]
        public async Task KeepsSessionOpen()
        {
            var skill = await new InternationalizationSkill()
                .LoadRequest(IntlSampleQueries.LaunchRequest)
                .ProcessRequestAsync();
            Assert.AreEqual(false, skill.ShouldEndSession);
        }

    }
}

