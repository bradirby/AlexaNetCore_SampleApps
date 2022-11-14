using AlexaNetCore.Interfaces;
using AlexaNetCore.RequestModel;

namespace AlexaNetCore.ZeroToHero.Interceptors
{
    public class FindUserRequestInterceptor : AlexaBaseRequestInterceptor
    {
        public override Task ProcessAsync(IAlexaRequestEnvelope reqEnv)
        {
            var usrid = reqEnv.GetUserId();

            //add code to lookup the user information

            SetSessionValue(SkillConstants.SessionAttributeNames.Username,"Jeff Bezos");
            return Task.FromResult(reqEnv);
        }
    }
}