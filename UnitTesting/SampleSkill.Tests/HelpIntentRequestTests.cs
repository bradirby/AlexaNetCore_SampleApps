using AlexaNetCore;
using NUnit.Framework;

namespace AlexaNetCoreSampleSkill.Tests
{
    public class HelpIntentRequestTests 
    {

        [Test]
        public void InvalidIntentName_ReturnsHelpText()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();

            Assert.AreEqual(AlexaOutputSpeechType.PlainText, skill.ResponseEnv.GetOutputSpeech().SpeechType);
            Assert.AreEqual("DefaultHelpIntentHandler", skill.ResponseEnv.IntentHandlerName);
            Assert.AreEqual("Sure, I can help you with that", skill.ResponseEnv.GetOutputSpeechText());
        }

        [Test]
        public void InvalidIntentName_DoesNotEndSession()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual(false, skill.ResponseEnv.ShouldEndSession);
        }

    }
}

