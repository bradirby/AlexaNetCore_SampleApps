using AlexaNetCore;

namespace AlexaNetCore.ZeroToHero.Slots
{
    public class SlotCheckerSkill : AlexaSkillBase
    {
        public SlotCheckerSkill()
        {
            SetSkillVersion("0.3.0");
            SetInvocationName("zero to hero test");


            RegisterIntentHandler(new DefaultLaunchIntentHandler("Welcome to the slot checker"));

            RegisterIntentHandler(new DefaultHelpIntentHandler(""));

            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, Cancelling"));
            RegisterIntentHandler(new DefaultStopIntentHandler("OK, Stopping"));
            RegisterIntentHandler(new DefaultSessionEndRequest("OK, Ending"));
            RegisterIntentHandler(new DefaultFallbackIntentHandler());
            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler());


            RegisterIntentHandler(new DateSlotIntent());
            RegisterIntentHandler(new DurationSlotCheckerIntent());
            RegisterIntentHandler(new FourDigitNumberSlotCheckerIntent());
            RegisterIntentHandler(new NumberSlotCheckerIntent());
            RegisterIntentHandler(new OrdinalSlotCheckerIntent());
            RegisterIntentHandler(new PhoneNumberSlotCheckerIntent());
            RegisterIntentHandler(new TimeSlotCheckerIntent());

            RegisterIntentHandler(new ActorNameSlotCheckerIntent());
            RegisterIntentHandler(new AnimalSlotCheckerIntent());
            RegisterIntentHandler(new USCitySlotCheckerIntent());
            RegisterIntentHandler(new USStateSlotCheckerIntent());

        }
    }
}
