using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AlexaNetCore.ZeroToHero.Interceptors
{
    /// <summary>
    /// A constant class that keeps all the slot names.
    /// Since slot names must be unique across the whole skill, it is best to keep them all in one place
    /// </summary>
    public static class SkillConstants
    {
        public class SlotNames
        {
        }

        public class SessionAttributeNames
        {
            public static string Username = "username";
        }


        public class IntentNames
        {
            public static string InterceptIntent => "InterceptorIntentHandler";
        }

    }
}
