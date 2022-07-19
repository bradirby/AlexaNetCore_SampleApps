using System.Threading.Tasks;
using AlexaNetCore;
using NUnit.Framework;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.Interceptors.Tests
{
    public class InterceptorIntentTests
    {

        [Test]
        public async Task InterceptorSetsUserName()
        {
            var skill = new InterceptorSkill();
            skill.LoadRequest(InterceptorSampleQueries.IsInterceptorActive);
            await skill.ProcessRequestAsync();

            Assert.AreEqual("Jeff Bezos", skill.GetResponseSessionValue(SkillConstants.SessionAttributeNames.Username, ""));
        }
    }
}

