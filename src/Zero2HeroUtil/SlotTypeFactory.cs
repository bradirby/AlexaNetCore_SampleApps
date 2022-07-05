using AlexaNetCore;
using AlexaNetCore.InteractionModel;
using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.Util
{
    public static  class SlotTypeFactory
    {
        public static void AddMonthNameSlot(this AlexaSkillBase skill, string slotTypeName)
        {
            skill.AddCustomSlotType(new AlexaCustomSlotType(slotTypeName)
                .AddValueOption("1","January", new [] {"first month"})
                .AddValueOption("2","February")
                .AddValueOption("3","March")
                .AddValueOption("4","April")
                .AddValueOption("5","May")
                .AddValueOption("6","June")
                .AddValueOption("7","July")
                .AddValueOption("8","August")
                .AddValueOption("9","September", new [] {"When School Starts"})
                .AddValueOption("10","October")
                .AddValueOption("11","November")
                .AddValueOption("12","December", new [] {"Last Month", "Christmas month"}));
        }

        public static void AddCarNameSlot(this AlexaSkillBase skill, string slotTypeName)
        {
            skill.AddCustomSlotType(new AlexaCustomSlotType(slotTypeName)
                .AddValueOption( "Chevrolet", new[] { "Chevy" })
                .AddValueOption( "Ford")
                .AddValueOption( "Tesla"));
        }


    }
}
