using Microsoft.Extensions.Logging;
using NUnit.Framework;
using System.Threading.Tasks;

namespace AlexaNetCore.ZeroToHero.Internationalization.Tests
{
    internal class IntlIntentTest
    {

        [Test]
        public async Task IntlIntent_English()
        {
            var skill = await new InternationalizationSkill(new LoggerFactory())
                .LoadRequest(IntlSampleQueries.WhatLanguagesTrained)
                .ProcessRequestAsync();
            Assert.AreEqual("I can speak English! Also Spanish and Italian.", skill.GetSpokenText());
        }


    }
}
