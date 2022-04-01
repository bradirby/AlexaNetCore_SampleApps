using AlexaNetCore;
using NUnit.Framework;
using SkillSlots;
using SkillSlots.Tests;
using SlotChecker;

namespace SkillSlots.Tests
{
    public class CancelSessionRequestTests 
    {
        [Test]
        public void CancelRequest_SaysGoodbye()
        {
            var skill = new SlotCheckerSkill().LoadRequest(GenericSkillRequests.CancelRequest()).ProcessRequest();
            Assert.AreEqual("OK, Canceling slot checker", skill.ResponseEnv.GetOutputSpeechText(AlexaLocale.English_US));
        }

        [Test]
        public void CancelRequest_EndsSession()
        {
            var skill = new SlotCheckerSkill().LoadRequest(GenericSkillRequests.CancelRequest()).ProcessRequest();
            Assert.AreEqual(true, skill.ResponseEnv.ShouldEndSession);
        }

    }
}

