using AlexaNetCore;
using NUnit.Framework;

namespace AlexaNetCoreSampleSkill.Tests
{
    public class HowIsTodayRequestTests 
    {

        [Test]
        public void EmptyRequest_AsksIfUserNeedsHelp()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.EmptyRequest()).ProcessRequest();

            Assert.AreEqual(AlexaOutputSpeechType.PlainText, skill.ResponseEnv.GetOutputSpeech().SpeechType);
            Assert.AreEqual("Sure, I can help you with that", skill.ResponseEnv.GetOutputSpeechText(AlexaLocale.English_US));
        }

        [Test]
        public void EmptyRequest_DoesNotEndSession()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.EmptyRequest()).ProcessRequest();
            Assert.AreEqual(false, skill.ResponseEnv.ShouldEndSession);
        }

        [Test]
        public void EmptyRequest_DoesNotReturnCard()
        {
            var skill = new AlexaNetCoreHelloWorldSkill().LoadRequest(GenericSkillRequests.EmptyRequest()).ProcessRequest();
            Assert.IsNull( skill.ResponseEnv.GetCard());
        }
       

    }
}

