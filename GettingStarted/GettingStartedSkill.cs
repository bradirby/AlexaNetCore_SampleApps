using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexaNetCore;

namespace AlexaNetCoreGettingStarted
{
    public class GettingStartedSkill : AlexaSkillBase
    {
        public GettingStartedSkill()
        {
            SetSkillVersion("0.1");
            RegisterIntentHandler(new DefaultLaunchIntentHandler("I Love Alexa Net Core"));
        }
    }
}
