
using AlexaNetCore;
using NUnit.Framework;

namespace SlotChecker.Tests
{
    public class NumberCheckerIntentTests 
    {

        [Test]
        public void NegativeFour()
        {
            var skill = new SlotCheckerSkill();
            skill.LoadRequest(NumberSlotCheckerQueries.NegativeFour()).ProcessRequest();

            var expectedVal = "got the single value  negative  4"; 
            Assert.AreEqual("NumberSlotCheckerIntent", skill.ResponseEnv.IntentHandlerName);
            Assert.AreEqual(expectedVal, skill.ResponseEnv.GetOutputSpeechText());
        }


    }
}

