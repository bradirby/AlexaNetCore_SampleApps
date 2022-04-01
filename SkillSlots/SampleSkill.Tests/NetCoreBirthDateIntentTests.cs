using AlexaNetCore;
using NUnit.Framework;
using SkillSlots;
using SkillSlots.Tests;
using SlotChecker;

namespace SkillSlots.Tests
{
    public class NetCoreBirthDateIntentTests 
    {

      

        [Test]
        public void EmptyRequest_DoesNotEndSession()
        {
            var skill = new SlotCheckerSkill().LoadRequest(GenericSkillRequests.EmptyRequest()).ProcessRequest();
            Assert.AreEqual(false, skill.ResponseEnv.ShouldEndSession);
        }

      

    }
}

