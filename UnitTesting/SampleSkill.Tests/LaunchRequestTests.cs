using AlexaNetCore;
using NUnit.Framework;

namespace UnitTestingSkill.Tests
{
    public class LaunchRequestTests 
    {

        [Test]
        public void LaunchRequest_InvokeWithNoIntent_SaysHello()
        {
            var skill = new GettingStartedSkill().LoadRequest(GenericSkillRequests.LaunchRequest()).ProcessRequest();
            Assert.AreEqual("I Love Alexa Net Core", skill.ResponseEnv.GetOutputSpeechText());
        }
      

    }
}

