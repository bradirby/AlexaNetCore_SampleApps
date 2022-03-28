using System;
using AlexaNetCore;
using UnitTestingSkill.Intents;

namespace UnitTestingSkill
{
    public class GettingStartedSkill : AlexaSkillBase
    {

        public GettingStartedSkill() : base()
        {
            SetSkillVersion("0.1");
            RegisterIntentHandler(new DefaultLaunchIntentHandler("I Love Alexa Net Core"));
            RegisterIntentHandler(new DefaultStopIntentHandler("OK, stopping.  Thanks for visiting"));
            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, canceling.  Thanks for visiting"));
            RegisterIntentHandler(new DefaultHelpIntentHandler("I haven't added the help yet"));
            RegisterIntentHandler(new DefaultFallbackIntentHandler("Default intent asks if you can try that again"));

            //register your custom intent handlers
            RegisterIntentHandler(new NetCoreBirthDateIntentHandler());
        }

        
    }
}
