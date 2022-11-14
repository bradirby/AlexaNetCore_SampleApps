using System.Threading.Tasks;
using AlexaNetCore;
using Interceptors.Tests.Interceptors;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace AlexaNetCore.ZeroToHero.Interceptors.Tests
{
    public class RequestInterceptorTests
    {

        [Test]
        public async Task FindUserInterceptor_AddsUsernameToRequest()
        {
            var skill = await new InterceptorSkill(new LoggerFactory())
                .RegisterRequestInterceptor(new SetUserIdDebugInterceptor("jeff"))  
                .LoadRequest(InterceptorSampleQueries.LaunchRequest)
                .ProcessRequestAsync();

            Assert.AreEqual("Jeff Bezos", skill.GetResponseSessionValue(SkillConstants.SessionAttributeNames.Username, ""));
        }
    }
}

