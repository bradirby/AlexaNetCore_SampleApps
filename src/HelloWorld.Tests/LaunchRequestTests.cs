using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.HelloWorld.Tests
{
    public class LaunchRequestTests
    {

        [Test]
        public async Task ReturnsProperTextString()
        {
            var skill = new HelloWorldSkill();
            skill.LoadRequest(HelloWorldSampleQueries.LaunchRequest);
            await skill.ProcessRequestAsync();

            Assert.AreEqual("I Love Alexa Net Core. Try saying 'How old is Dot Net Core' or 'When was Dot Net born'",
                skill.GetSpokenText());
        }

    }
}

