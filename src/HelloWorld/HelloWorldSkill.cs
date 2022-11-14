using AlexaNetCore;
using Microsoft.Extensions.Logging;

namespace AlexaNetCore.ZeroToHero.HelloWorld
{
    public class HelloWorldSkill : AlexaSkillBase
    {
        public HelloWorldSkill(ILoggerFactory loggerFactory) : base(loggerFactory)
        {
            SetSkillVersion("0.1.0");
            SetInvocationName("alexanetcore hello world");

            RegisterIntentHandler(new DefaultLaunchIntentHandler("I Love Alexa Net Core. Try saying 'How old is Dot Net Core' or 'When was Dot Net born'"));

            RegisterIntentHandler(new HelloWorldIntentHandler());


            RegisterIntentHandler(new DefaultHelpIntentHandler("You can say 'How old is Dot Net Core' or 'When was Dot Net born'.  Give it a try"));

            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler("OK, Navigating home"));
            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, Cancelling"));
            RegisterIntentHandler(new DefaultStopIntentHandler("Ok, stopping"));
            RegisterIntentHandler(new DefaultSessionEndRequest("Ok, ending"));
            RegisterIntentHandler(new DefaultFallbackIntentHandler("Ok, falling back"));
        }
    }
}
