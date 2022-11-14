using System.Threading.Tasks;
using AlexaNetCore;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace AlexaNetCore.ZeroToHero.Interceptors.Tests
{
    public class InterceptorIntentTests
    {

        [Test]
        public async Task InterceptorSetsUserName()
        {
            var skill = new InterceptorSkill(new LoggerFactory());
            skill.LoadRequest(InterceptorSampleQueries.IsInterceptorActive);
            await skill.ProcessRequestAsync();

            Assert.AreEqual("Jeff Bezos", skill.GetResponseSessionValue(SkillConstants.SessionAttributeNames.Username, ""));
        }
    }
}

