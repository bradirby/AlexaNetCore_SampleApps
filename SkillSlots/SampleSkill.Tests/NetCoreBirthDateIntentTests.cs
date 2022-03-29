using AlexaNetCore;
using NUnit.Framework;
using SkillSlots;
using SkillSlots.Tests;

namespace SkillSlots.Tests
{
    public class NetCoreBirthDateIntentTests 
    {

        [Test]
        public void EmptyRequest_AsksIfUserNeedsHelp()
        {
            var skill = new BirthdayEchoSkill().LoadRequest(GenericSkillRequests.EmptyRequest()).ProcessRequest();
            Assert.AreEqual("Just tell me your birthday and I will echo it back to you", skill.ResponseEnv.GetOutputSpeechText());
        }

        [Test]
        public void EmptyRequest_DoesNotEndSession()
        {
            var skill = new BirthdayEchoSkill().LoadRequest(GenericSkillRequests.EmptyRequest()).ProcessRequest();
            Assert.AreEqual(false, skill.ResponseEnv.ShouldEndSession);
        }

      

    }
}

