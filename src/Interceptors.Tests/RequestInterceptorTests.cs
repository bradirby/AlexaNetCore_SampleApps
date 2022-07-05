using System.Threading.Tasks;
using AlexaNetCore;
using NUnit.Framework;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.Interceptors.Tests
{
    public class RequestInterceptorTests
    {

        [Test]
        public async Task FindUserInterceptor_AddsUsernameToRequest()
        {
            var skill = await new InterceptorSkill()
                .RegisterRequestInterceptor(new SetUserIdDebugInterceptor("jeff"), 100)  //set the userid for testing
                .LoadRequest(BuiltInIntentQueries.LaunchRequest)
                .ProcessRequestAsync();

            Assert.AreEqual("Jeff Bezos", skill.GetResponseSessionValue(SkillConstants.SessionAttributeNames.Username, ""));
        }
    }
}

