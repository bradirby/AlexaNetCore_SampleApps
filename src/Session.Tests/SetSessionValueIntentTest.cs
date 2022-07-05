using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.Session.Tests
{
    internal class SetSessionValueIntentTest
    {

        [Test]
        public async Task CardBodyTextCorrect()
        {
            var skill = new SessionDemoSkill().LoadRequest(BuiltInIntentQueries.GetRequestWithIntentName(SkillConstants.IntentNames.GetSessionValueIntent));

            //get the intent we want to test
            var intent = skill.GetRegisteredIntent(AlexaIntentType.Custom, SkillConstants.IntentNames.GetSessionValueIntent);
            
            //add interceptor for the intent so it looks like the request already had the slot value 
            intent.RegisterRequestInterceptor(new SetSessionValueDebugInterceptor(SkillConstants.SessionValueNames.ActorName, "Brad Pitt"));

            //process
            await skill.ProcessRequestAsync();

            Assert.AreEqual("Your favorite actor is Brad Pitt", skill.GetSpokenText());
        }


    }
}
