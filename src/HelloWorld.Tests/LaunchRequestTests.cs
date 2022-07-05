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
            skill.LoadRequest(BuiltInIntentQueries.LaunchRequest);
            await skill.ProcessRequestAsync();

            Assert.AreEqual("Welcome to your first skill.  You can say 'Tell me Hello' or 'i want to hear you say hello'.  Do you want to give it a try?",
                skill.GetSpokenText());
        }


        [Test]
        public async Task KeepsSessionOpen()
        {
            var skill = new HelloWorldSkill();
            skill.LoadRequest(BuiltInIntentQueries.LaunchRequest);
            await skill.ProcessRequestAsync();

            Assert.AreEqual(false, skill.ShouldEndSession);
        }

    }
}

