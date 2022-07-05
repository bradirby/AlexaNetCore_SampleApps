using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.MultiturnDialog
{
    public class MultiturnDialogSkill : AlexaSkillBase
    {
        public MultiturnDialogSkill()
        {
            SetSkillVersion("0.1.0");
            SetInvocationName("alexanetcore multiturn");

            AddCustomSlotType(new AlexaCustomSlotType(SkillConstants.SlotTypes.TimeOfDay)
                .AddValueOption(new AlexaCustomSlotTypeValueOption("B", "breakfast"))
                .AddValueOption(new AlexaCustomSlotTypeValueOption("L", "Lunch"))
                .AddValueOption(new AlexaCustomSlotTypeValueOption("D", "Dinner",new string[] {"supper"})));

            AddCustomSlotType(new AlexaCustomSlotType(SkillConstants.SlotTypes.Cuisine)
                .AddValueOption(new AlexaCustomSlotTypeValueOption("NONE", "Normal"))
                .AddValueOption(new AlexaCustomSlotTypeValueOption("SPI", "Spicy"))
                .AddValueOption(new AlexaCustomSlotTypeValueOption("SAV", "Savory"))
                .AddValueOption(new AlexaCustomSlotTypeValueOption("KOR", "Korean")));

            AddCustomSlotType(new AlexaCustomSlotType(SkillConstants.SlotTypes.Allergies)
                .AddValueOption(new AlexaCustomSlotTypeValueOption("NONE","None",new []{"Nothing","no", "not really", "not to food"}))
                .AddValueOption(new AlexaCustomSlotTypeValueOption("SH","Shellfish"))
                .AddValueOption(new AlexaCustomSlotTypeValueOption("PEA", "Peanuts")));

            AddCustomSlotType(new AlexaCustomSlotType(SkillConstants.SlotTypes.Diet)
                .AddValueOption(new AlexaCustomSlotTypeValueOption("PES", "Pescatarian")));

            AddCustomSlotType(new AlexaCustomSlotType(SkillConstants.SlotTypes.Location)
                .AddValueOption(new AlexaCustomSlotTypeValueOption("OUT", "Get out of the office")));

            RegisterIntentHandler(new RecommendationIntent());
            AddRequiredHandlers();
        }

        private void AddRequiredHandlers()
        {
            RegisterIntentHandler(new DefaultLaunchIntentHandler("What do you want to eat today?"));
            RegisterIntentHandler(new DefaultHelpIntentHandler("You can say 'Tell Me Hello' or 'i want to hear you say hello'.  Give it a try"));

            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler("OK, Navigating home"));
            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, Cancelling"));
            RegisterIntentHandler(new DefaultStopIntentHandler("Ok, stopping"));
            RegisterIntentHandler(new DefaultSessionEndRequest("Ok, ending"));
            RegisterIntentHandler(new DefaultFallbackIntentHandler("Ok, falling back"));

        }
    }
}
