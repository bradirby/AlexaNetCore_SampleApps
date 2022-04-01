using AlexaNetCore;
using NUnit.Framework;
using SkillSlots;
using SkillSlots.Tests;
using SlotChecker;

namespace SkillSlots.Tests
{
    public class HelpIntentRequestTests 
    {

        [Test]
        public void HelpRequest_ProcessedByCorrectIntentHandler()
        {
            var skill = new SlotCheckerSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual(AlexaBuiltInIntents.HelpIntent, skill.ResponseEnv.IntentHandlerName);
        }

        [Test]
        public void HelpRequest_ReturnsHelpText()
        {
            var skill = new SlotCheckerSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual("you got slot checker help", skill.ResponseEnv.GetOutputSpeechText());
        }

        [Test]
        public void HelpRequest_DoesNotEndSession()
        {
            var skill = new SlotCheckerSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual(false, skill.ResponseEnv.ShouldEndSession);
        }

    }
}

