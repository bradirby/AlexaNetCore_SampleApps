using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaNetCore.ZeroToHero.DynamicEntities
{
    internal class SkillConstants
    {
        public class SessionVarNames
        {
            public static string StateName => "stateNameSessVar";
        }

        public class SlotNames
        {
            public static string StateName=> "stateName";
            public static string CountyName => "countyName";
        }

        public class SlotTypes
        {
            public static string StateName=> "stateNameType";
            public static string CountyName => "countyNameType";
        }

        public class RequestModifierNames
        {
        }


        public class IntentNames
        {
            public static string GetStateIntent=> "GetStateIntent";
            public static string GetCountyIntent=> "GetCountyIntent";
        }

    }
}
