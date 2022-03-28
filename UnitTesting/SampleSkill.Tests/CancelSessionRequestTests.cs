using AlexaNetCore;
using NUnit.Framework;
using UnitTestingSkill;
using UnitTestingSkill.Tests;

namespace AlexaNetCoreSampleSkill.Tests
{
    public class CancelSessionRequestTests 
    {
        [Test]
        public void CancelRequest_SaysGoodbye()
        {
            var skill = new GettingStartedSkill().LoadRequest(GenericSkillRequests.CancelRequest()).ProcessRequest();
            Assert.AreEqual("OK, canceling.  Thanks for visiting", skill.ResponseEnv.GetOutputSpeechText(AlexaLocale.English_US));
        }

        [Test]
        public void CancelRequest_EndsSession()
        {
            var skill = new GettingStartedSkill().LoadRequest(GenericSkillRequests.CancelRequest()).ProcessRequest();
            Assert.AreEqual(true, skill.ResponseEnv.ShouldEndSession);
        }

    }
}

