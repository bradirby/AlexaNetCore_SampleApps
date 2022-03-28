using AlexaNetCore;
using NUnit.Framework;

namespace AlexaNetCoreSampleSkill.Tests
{
    public class CancelSessionRequestTests 
    {
        [Test]
        public void CancelRequest_SaysGoodbye()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.CancelRequest()).ProcessRequest();
            Assert.AreEqual(AlexaOutputSpeechType.PlainText, skill.ResponseEnv.GetOutputSpeech().SpeechType);
            Assert.AreEqual("Ok, canceling", skill.ResponseEnv.GetOutputSpeechText(AlexaLocale.English_US));
        }

        [Test]
        public void CancelRequest_EndsSession()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.CancelRequest()).ProcessRequest();
            Assert.AreEqual(true, skill.ResponseEnv.ShouldEndSession);
        }

    }
}

