using AlexaNetCore;

namespace AlexaNetCore.ZeroToHero.Session
{
    public class SessionDemoSkill : AlexaSkillBase
    {
        public SessionDemoSkill()
        {
            SetSkillVersion("0.3.0");
            SetInvocationName("alexanetcore session demo");

            RegisterIntentHandler(new GetSessionValueIntent());
            RegisterIntentHandler(new SetSessionValueIntent());

            RegisterIntentHandler(new DefaultLaunchIntentHandler("Hi, Lets experiment with session.  Just tell me who your favorite actor is"));

            RegisterIntentHandler(new DefaultHelpIntentHandler("Tell me who your favorite actor is"));

            RegisterIntentHandler(new DefaultCancelIntentHandler());
            RegisterIntentHandler(new DefaultStopIntentHandler());
            RegisterIntentHandler(new DefaultSessionEndRequest());
            RegisterIntentHandler(new DefaultFallbackIntentHandler());
            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler());

        }
    }
}
