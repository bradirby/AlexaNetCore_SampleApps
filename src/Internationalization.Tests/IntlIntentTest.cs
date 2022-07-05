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
                .LoadRequest(InternationalizationSampleQueries.WhatLanguagesTrained_English)
                .ProcessRequestAsync();
            Assert.AreEqual("I can speak English! Also Spanish and Italian.", skill.GetSpokenText());
        }

        [Test]
        public async Task IntlIntent_Spanish()
        {
            var skill = await new InternationalizationSkill()
                .LoadRequest(InternationalizationSampleQueries.WhatLanguagesTrained_Spanish)
                .ProcessRequestAsync();
            Assert.AreEqual("Hablo ingles, espanol y italiano.", skill.GetSpokenText());
        }

        [Test]
        public async Task IntlIntent_Italian()
        {
            var skill = await new InternationalizationSkill()
                .LoadRequest(InternationalizationSampleQueries.WhatLanguagesTrained_Italian)
                .ProcessRequestAsync();
            Assert.AreEqual("Parlo inglese, spagnolo e italiano", skill.GetSpokenText());
        }


    }
}
