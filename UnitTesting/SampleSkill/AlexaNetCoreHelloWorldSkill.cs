using System;
using AlexaNetCore;
using AlexaNetCoreSampleSkill.Intents;

namespace AlexaNetCoreSampleSkill
{
    public class AlexaNetCoreHelloWorldSkill : AlexaSkillBase
    {

        public AlexaNetCoreHelloWorldSkill() : base()
        {
            SetSkillVersion("0.1");

            SetSkillVersion("0.1");
            RegisterIntentHandler(new DefaultLaunchIntentHandler("I Love Alexa Net Core"));
            RegisterIntentHandler(new DefaultStopIntentHandler("Ok, thanks for stopping in"));
            RegisterIntentHandler(new DefaultHelpIntentHandler("Sure, I can help you with that"));

            //the following line will register all the default handlers with the given string
            //note that since the Launch and Stop intent handlers are already registered,
            //they will not be overwritten
            RegisterDefaultIntentHandlers("Uh oh, I haven't learned how to do that yet");

            //if I register a specific handler a second time, it WILL be overwritten
            RegisterIntentHandler(new DefaultCancelIntentHandler("Ok, canceling"));

            //Then register your custom intent handlers
            RegisterIntentHandler(new HelloWorldIntentHandler());
        }

        
    }
}
