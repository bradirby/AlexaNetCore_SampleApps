using AlexaNetCore.Interfaces;
using AlexaNetCore.RequestModel;

namespace AlexaNetCore.ZeroToHero.Util;


/// <summary>
/// This interceptor is for use in debug to set the incoming userid to a specific property for testing
/// </summary>
public class SetUserIdDebugInterceptor: IAlexaRequestInterceptor
{
    private string UserId;

    public SetUserIdDebugInterceptor(string userId)
    {
        UserId = userId;
    }

    public Task<AlexaRequestEnvelope> ProcessAsync(AlexaRequestEnvelope reqEnv)
    {
        reqEnv.Session.User.UserID = UserId;
        return Task.FromResult( reqEnv);
    }

}