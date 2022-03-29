using AlexaNetCore;
using NUnit.Framework;
using SkillSlots;
using SkillSlots.Tests;

namespace SkillSlots.Tests
{
    public class HelpIntentRequestTests 
    {

        [Test]
        public void HelpRequest_ProcessedByCorrectIntentHandler()
        {
            var skill = new BirthdayEchoSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual("DefaultHelpIntentHandler", skill.ResponseEnv.IntentHandlerName);
        }

        [Test]
        public void HelpRequest_ReturnsHelpText()
        {
            var skill = new BirthdayEchoSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual("Just tell me your birthday and I will echo it back to you", skill.ResponseEnv.GetOutputSpeechText());
        }

        [Test]
        public void HelpRequest_DoesNotEndSession()
        {
            var skill = new BirthdayEchoSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual(false, skill.ResponseEnv.ShouldEndSession);
        }

    }
}

