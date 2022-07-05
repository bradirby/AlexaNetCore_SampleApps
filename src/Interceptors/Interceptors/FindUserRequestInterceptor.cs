using AlexaNetCore.Interfaces;
using AlexaNetCore.RequestModel;

namespace AlexaNetCore.ZeroToHero.Interceptors
{
    public class FindUserRequestInterceptor : IAlexaRequestInterceptor
    {
        public Task<AlexaRequestEnvelope> ProcessAsync(AlexaRequestEnvelope reqEnv)
        {
            var usrid = reqEnv.GetUserId();

            //add code to lookup the user information

            reqEnv.SetSessionAttributeValue(SkillConstants.SessionAttributeNames.Username,"Jeff Bezos");
            return Task.FromResult(reqEnv);
        }
    }
}