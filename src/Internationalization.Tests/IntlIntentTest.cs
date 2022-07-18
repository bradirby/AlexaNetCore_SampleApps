using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.Internationalization.Tests
{
    internal class IntlIntentTest
    {

        [Test]
        public async Task IntlIntent_English()
        {
            var skill = await new InternationalizationSkill()
                .LoadRequest(IntlSampleQueries.WhatLanguagesTrained)
                .ProcessRequestAsync();
            Assert.AreEqual("I can speak English! Also Spanish and Italian.", skill.GetSpokenText());
        }


    }
}
