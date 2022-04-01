using AlexaNetCore;
using NUnit.Framework;
using SlotChecker;

namespace SkillSlots.Tests
{
    public class LaunchRequestTests 
    {

        [Test]
        public void LaunchRequest_InvokeWithNoIntent_SaysHello()
        {
            var skill = new SlotCheckerSkill().LoadRequest(GenericSkillRequests.LaunchRequest()).ProcessRequest();
            Assert.AreEqual("LaunchRequest", skill.ResponseEnv.IntentHandlerName);
        }
      

    }
}

