using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.DynamicEntities
{
    public class DynamicEntitySkill : AlexaSkillBase
    {
        public DynamicEntitySkill()
        {
            SetSkillVersion("0.1.0");
            SetInvocationName("alexanetcore multiturn");

            AddCustomSlotType(new AlexaCustomSlotType(SkillConstants.SlotTypes.StateName)
                .AddValueOption(new AlexaCustomSlotTypeValueOption("CA", "California"))
                .AddValueOption(new AlexaCustomSlotTypeValueOption("VA", "Virginia"))
                .AddValueOption(new AlexaCustomSlotTypeValueOption("FL", "Florida")));

            AddCustomSlotType(new AlexaCustomSlotType(SkillConstants.SlotTypes.CountyName)
                .AddValueOption(new AlexaCustomSlotTypeValueOption("N/A", "None")));


            RegisterIntentHandler(new GetStateIntent());
            RegisterIntentHandler(new GetCountyIntent());
            AddRequiredHandlers();
        }

        private void AddRequiredHandlers()
        {
            RegisterIntentHandler(new DefaultLaunchIntentHandler("What state do you live in?"));
            RegisterIntentHandler(new DefaultHelpIntentHandler("Tell me the state you live in, then you can select a county"));

            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler("OK, Navigating home"));
            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, Cancelling"));
            RegisterIntentHandler(new DefaultStopIntentHandler("Ok, stopping"));
            RegisterIntentHandler(new DefaultSessionEndRequest("Ok, ending"));
            RegisterIntentHandler(new DefaultFallbackIntentHandler("Ok, falling back"));

        }
    }
}
