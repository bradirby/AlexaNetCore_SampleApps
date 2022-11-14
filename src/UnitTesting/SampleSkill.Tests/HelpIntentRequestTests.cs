using AlexaNetCore;
using NUnit.Framework;
using UnitTestingSkill;
using UnitTestingSkill.Tests;

namespace AlexaNetCoreSampleSkill.Tests
{
    public class HelpIntentRequestTests 
    {

        [Test]
        public void HelpRequest_ProcessedByCorrectIntentHandler()
        {
            var skill = new GettingStartedSkill().LoadRequest(GenericSkillRequests.HelpRequest()).ProcessRequest();
            Assert.AreEqual(AlexaBuiltInIntents.HelpIntent, skill.ResponseEnv.IntentHandlerName);
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

