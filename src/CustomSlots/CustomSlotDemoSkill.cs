using AlexaNetCore;
using AlexaNetCore.InteractionModel;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.CustomSlots
{
    public class CustomSlotDemoSkill : AlexaSkillBase
    {
        public CustomSlotDemoSkill()
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
    }
}
