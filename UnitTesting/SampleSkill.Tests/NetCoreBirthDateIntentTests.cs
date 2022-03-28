using AlexaNetCore;
using NUnit.Framework;
using UnitTestingSkill;
using UnitTestingSkill.Tests;

namespace AlexaNetCoreSampleSkill.Tests
{
    public class NetCoreBirthDateIntentTests 
    {

        [Test]
        public void EmptyRequest_AsksIfUserNeedsHelp()
        {
            var skill = new GettingStartedSkill().LoadRequest(GenericSkillRequests.EmptyRequest()).ProcessRequest();
            Assert.AreEqual("I haven't added the help yet", skill.ResponseEnv.GetOutputSpeechText());
        }

        [Test]
        public void EmptyRequest_DoesNotEndSession()
        {
            var skill = new GettingStartedSkill().LoadRequest(GenericSkillRequests.EmptyRequest()).ProcessRequest();
            Assert.AreEqual(false, skill.ResponseEnv.ShouldEndSession);
        }

      

    }
}

