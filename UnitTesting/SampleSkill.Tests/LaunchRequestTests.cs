using AlexaNetCore;
using NUnit.Framework;

namespace AlexaNetCoreSampleSkill.Tests
{
    public class LaunchRequestTests 
    {

        [Test]
        public void LaunchRequest_InvokeWithNoIntent_SaysHello()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.LaunchRequest()).ProcessRequest();

            Assert.AreEqual(AlexaOutputSpeechType.PlainText, skill.ResponseEnv.GetOutputSpeech().SpeechType);
            Assert.AreEqual("I Love Alexa Net Core", skill.ResponseEnv.GetOutputSpeechText());
        }

        [Test]
        public void OpenRequest_InvokeWithNoIntent_SaysHello()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.OpenRequest()).ProcessRequest();

            Assert.AreEqual(AlexaOutputSpeechType.PlainText, skill.ResponseEnv.GetOutputSpeech().SpeechType);
            Assert.AreEqual("I Love Alexa Net Core", skill.ResponseEnv.GetOutputSpeechText());
        }

        [Test]
        public void StartSession_InvokeWithNoIntent_SaysHello()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.StartSession()).ProcessRequest();

            Assert.AreEqual(AlexaOutputSpeechType.PlainText, skill.ResponseEnv.GetOutputSpeech().SpeechType);
            Assert.AreEqual("I Love Alexa Net Core", skill.ResponseEnv.GetOutputSpeechText());
        }


    }
}

