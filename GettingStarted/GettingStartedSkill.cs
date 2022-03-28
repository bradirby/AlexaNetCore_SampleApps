using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexaNetCore;
using AlexaNetCore_GettingStarted.Intents;

namespace AlexaNetCore_GettingStarted
{
    public class GettingStartedSkill : AlexaSkillBase
    {
        public GettingStartedSkill()
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
