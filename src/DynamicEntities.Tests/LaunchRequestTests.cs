using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.DynamicEntities.Tests
{
    public class LaunchRequestTests
    {

        //[Test]
        //public async Task ReturnsProperTextString()
        //{
        //    var skill = new MultiturnDialogSkill();
        //    skill.LoadRequest(BuiltInIntentQueries.LaunchRequest);
        //    await skill.ProcessRequestAsync();

        //    Assert.AreEqual("Hello to the multiturn dialog test.  I'm launching the elicit slot dialog",
        //        skill.GetSpokenText());
        //}


        [Test]
        public async Task KeepsSessionOpen()
        {
            var skill = new DynamicEntitySkill();
            skill.LoadRequest(BuiltInIntentQueries.LaunchRequest);
            await skill.ProcessRequestAsync();

            Assert.AreEqual(false, skill.ShouldEndSession);
        }

    }
}

