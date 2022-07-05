using AlexaNetCore.Interfaces;
using AlexaNetCore.RequestModel;

namespace AlexaNetCore.ZeroToHero.Util;


/// <summary>
/// This interceptor is for use in debug to set the incoming userid to a specific property for testing
/// </summary>
public class SetSessionValueDebugInterceptor: IAlexaRequestInterceptor
{
    private string SessionVal;
    private string SessionKey;

    public SetSessionValueDebugInterceptor(string sessionKey, string sessionVal)
    {
        SessionVal = sessionVal;
        SessionKey = sessionKey;
    }

    public Task<AlexaRequestEnvelope> ProcessAsync(AlexaRequestEnvelope reqEnv)
    {
        reqEnv.SetSessionAttributeValue( SessionKey, SessionVal);
        return Task.FromResult( reqEnv);
    }

}