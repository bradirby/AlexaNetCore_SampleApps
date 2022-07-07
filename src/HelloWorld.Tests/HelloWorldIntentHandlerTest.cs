using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.HelloWorld.Tests
{
    internal class HelloWorldIntentHandlerTest
    {

        [Test]
        public async Task TellMeHello_ResponseProperly()
        {
            var skill = new HelloWorldSkill();
            skill.LoadRequest(HelloWorldSampleQueries.TellMeHello);
            await skill.ProcessRequestAsync();

            Assert.AreEqual("Dot Net Core is 2201 days old today", skill.GetSpokenText());
        }


    }
}
