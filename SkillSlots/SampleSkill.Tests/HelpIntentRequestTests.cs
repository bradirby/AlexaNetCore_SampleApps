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
            var skill = new GettingStartedSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual("DefaultHelpIntentHandler", skill.ResponseEnv.IntentHandlerName);
        }

        [Test]
        public void HelpRequest_ReturnsHelpText()
        {
            var skill = new GettingStartedSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual("I haven't added the help yet", skill.ResponseEnv.GetOutputSpeechText());
        }

        [Test]
        public void HelpRequest_DoesNotEndSession()
        {
            var skill = new GettingStartedSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual(false, skill.ResponseEnv.ShouldEndSession);
        }

    }
}

