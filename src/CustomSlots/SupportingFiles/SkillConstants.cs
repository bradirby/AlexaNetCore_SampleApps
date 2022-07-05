using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaNetCore.ZeroToHero.CustomSlots
{

    public static class SkillConstants
    {
        /// <summary>
        /// A constant class that keeps all the slot names.
        /// Since slot names must be unique across the whole skill, it is best to keep them all in one place
        /// </summary>
        public static class SlotNames
        {
            public static string MonthNameSlotName => "monthNameSlot";
            public static string CarNameSlotName => "carNameSlot";

        }

        public static class SlotTypes
        {
            public static string MonthNameSlotType => "monthNameSlotType";
            public static string CarNameSlotType => "carNameSlotType";

        }

        public class IntentNames
        {
            public static string CarNameIntent => "CarNameIntent";
            public static string MonthNameIntent => "MonthNameIntent";

        }


    }
}
