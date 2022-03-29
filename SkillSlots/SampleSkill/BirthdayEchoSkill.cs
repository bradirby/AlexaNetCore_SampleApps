using System;
using AlexaNetCore;
using SkillSlots.Intents;

namespace SkillSlots
{
    public class BirthdayEchoSkill : AlexaSkillBase
    {

        public BirthdayEchoSkill() : base()
        {
            SetSkillVersion("0.1");
            InvocationName = "birthday echo";
            RegisterIntentHandler(new DefaultLaunchIntentHandler("I Love Alexa Net Core"));
            RegisterIntentHandler(new DefaultStopIntentHandler("OK, stopping.  Thanks for visiting"));
            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, canceling.  Thanks for visiting"));
            RegisterIntentHandler(new DefaultHelpIntentHandler("Just tell me your birthday and I will echo it back to you"));
            RegisterIntentHandler(new DefaultFallbackIntentHandler("I didn't catch your birthdate.  Please try again."));

            //register your custom intent handlers
            RegisterIntentHandler(new BirthDateIntentHandler());
        }

        
    }
}
