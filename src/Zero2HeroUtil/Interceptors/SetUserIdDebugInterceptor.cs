using AlexaNetCore.Interfaces;
using AlexaNetCore.RequestModel;

namespace AlexaNetCore.ZeroToHero.Util;


/// <summary>
/// This interceptor is for use in debug to set the incoming userid to a specific property for testing
/// </summary>
public class SetUserIdDebugInterceptor: AlexaBaseRequestInterceptor
{
    private string UserId;

    public SetUserIdDebugInterceptor(string userId)
    {
        UserId = userId;
    }

    public override Task ProcessAsync(IAlexaRequestEnvelope reqEnv)
    {
        reqEnv.Session.User.UserID = UserId;
        return Task.CompletedTask;
    }

}