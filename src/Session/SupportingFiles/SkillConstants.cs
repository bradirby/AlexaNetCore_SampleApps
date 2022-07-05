using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaNetCore.ZeroToHero.Session
{

    public static class SkillConstants
    {
        /// <summary>
        /// A constant class that keeps all the slot names.
        /// Since slot names must be unique across the whole skill, it is best to keep them all in one place
        /// </summary>
        public static class SlotNames
        {
            public static string ActorName => "ActorNameSlot";
        }

        public static class SessionValueNames
        {
            public static string ActorName => "ActorNameSessionVal";
        }

        public static class SlotTypes
        {

        }

        public class IntentNames
        {
            public static string SetSessionValueIntent => "SetSessionValue";
            public static string GetSessionValueIntent=> "GetResponseSessionValue";

        }


    }
}
