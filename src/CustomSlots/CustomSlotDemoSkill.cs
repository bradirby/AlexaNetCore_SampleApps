using AlexaNetCore;
using AlexaNetCore.InteractionModel;
using AlexaNetCore.Model;
using Microsoft.Extensions.Logging;

namespace AlexaNetCore.ZeroToHero.CustomSlots
{
    public class CustomSlotDemoSkill : AlexaSkillBase
    {
        public CustomSlotDemoSkill(ILoggerFactory loggerFactory):base(loggerFactory)
        {
            SetSkillVersion("0.3.0");
            SetInvocationName("alexanetcore custom slot demo");

            this.AddMonthNameSlot( SkillConstants.SlotTypes.MonthNameSlotType);
            this.AddCarNameSlot(SkillConstants.SlotTypes.CarNameSlotType);

            RegisterIntentHandler(new DefaultLaunchIntentHandler("Welcome to the custom slot demo."));

            RegisterIntentHandler(new MonthNameIntent());
            RegisterIntentHandler(new CarNameIntent());


            RegisterIntentHandler(new DefaultHelpIntentHandler());

            RegisterIntentHandler(new DefaultCancelIntentHandler("Ok, cancelling"));
            RegisterIntentHandler(new DefaultStopIntentHandler());
            RegisterIntentHandler(new DefaultSessionEndRequest());
            RegisterIntentHandler(new DefaultFallbackIntentHandler());
            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler());

        }

        private void AddMonthNameSlot(string slotTypeName)
        {
            AddCustomSlotType(new AlexaCustomSlotType(slotTypeName)
                .AddValueOption("1", "January", new[] { "first month" })
                .AddValueOption("2", "February")
                .AddValueOption("3", "March")
                .AddValueOption("4", "April")
                .AddValueOption("5", "May")
                .AddValueOption("6", "June")
                .AddValueOption("7", "July")
                .AddValueOption("8", "August")
                .AddValueOption("9", "September", new[] { "When School Starts" })
                .AddValueOption("10", "October")
                .AddValueOption("11", "November")
                .AddValueOption("12", "December", new[] { "Last Month", "Christmas month" }));
        }

        private void AddCarNameSlot(string slotTypeName)
        {
            AddCustomSlotType(new AlexaCustomSlotType(slotTypeName)
                .AddValueOption("Chevrolet", new[] { "Chevy" })
                .AddValueOption("Ford")
                .AddValueOption("Tesla"));
        }

    }
}
