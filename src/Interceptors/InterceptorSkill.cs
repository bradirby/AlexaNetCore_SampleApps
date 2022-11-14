using AlexaNetCore;
using Interceptors.Interceptors;
using Microsoft.Extensions.Logging;

namespace AlexaNetCore.ZeroToHero.Interceptors
{
    public class InterceptorSkill : AlexaSkillBase
    {
        public InterceptorSkill(ILoggerFactory loggerFactory):base(loggerFactory)
        {
            SetSkillVersion("0.3.0");
            SetInvocationName("alexanetcore interceptor demo");

            RegisterIntentHandler(new DefaultLaunchIntentHandler("Hi, you've found the interceptor test skill.  You can ask me if the interceptor is active.", 
                "The interceptors are running, are you still there?"));

            RegisterIntentHandler(new InterceptorIntentHandler());


            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler("Let's try again.  You've found the interceptor test skill.  You can ask me if the interceptor is active.", 
                "The interceptors are running, are you still there?"));

            RegisterIntentHandler(new DefaultHelpIntentHandler("Just ask if the interceptor is active"));

            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, Cancelling"));
            RegisterIntentHandler(new DefaultStopIntentHandler("OK, Stopping"));
            RegisterIntentHandler(new DefaultSessionEndRequest("OK, Ending"));

            RegisterIntentHandler(new DefaultFallbackIntentHandler("Let me think about that.  Is there anything else?"));

            RegisterRequestInterceptor(new FindUserRequestInterceptor());
            RegisterResponseInterceptor(new SetRepromptInterceptor("This is the injected reprompt."));
        }
    }
}
