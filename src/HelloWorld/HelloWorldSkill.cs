using AlexaNetCore;

namespace AlexaNetCore.ZeroToHero.HelloWorld
{
    public class HelloWorldSkill : AlexaSkillBase
    {
        public HelloWorldSkill()
        {
            SetSkillVersion("0.1.0");
            SetInvocationName("zero to hero test");

            RegisterIntentHandler(new DefaultLaunchIntentHandler("Welcome to your first skill.  You can say 'Tell me Hello' or 'i want to hear you say hello'.  Do you want to give it a try?"));

            RegisterIntentHandler(new HelloWorldIntentHandler());


            RegisterIntentHandler(new DefaultHelpIntentHandler("You can say 'Tell Me Hello' or 'i want to hear you say hello'.  Give it a try"));

            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler("OK, Navigating home"));
            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, Cancelling"));
            RegisterIntentHandler(new DefaultStopIntentHandler("Ok, stopping"));
            RegisterIntentHandler(new DefaultSessionEndRequest("Ok, ending"));
            RegisterIntentHandler(new DefaultFallbackIntentHandler("Ok, falling back"));
        }
    }
}
