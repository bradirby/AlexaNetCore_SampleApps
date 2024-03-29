﻿
using AlexaNetCore;
using Slots.Intents;

namespace Slots
{
    public class SlotCheckerSkill : AlexaSkillBase
    {
        public SlotCheckerSkill()
        {
            SetSkillVersion("0.3.0");
            SetInvocationName("alexanetcore slot value checker");


            RegisterIntentHandler(new DefaultLaunchIntentHandler("Welcome to the slot checker"));

            RegisterIntentHandler(new DefaultHelpIntentHandler(""));


            RegisterIntentHandler(new BirthYearIntent());

            //RegisterIntentHandler(new DateSlotIntent());
            //RegisterIntentHandler(new DurationSlotCheckerIntent());
            //RegisterIntentHandler(new FourDigitNumberIntent());
            //RegisterIntentHandler(new NumberSlotCheckerIntent());
            //RegisterIntentHandler(new OrdinalSlotCheckerIntent());
            //RegisterIntentHandler(new PhoneNumberSlotCheckerIntent());
            //RegisterIntentHandler(new TimeSlotCheckerIntent());

            //RegisterIntentHandler(new ActorNameSlotCheckerIntent());
            //RegisterIntentHandler(new AnimalSlotCheckerIntent());
            //RegisterIntentHandler(new USCitySlotCheckerIntent());
            //RegisterIntentHandler(new USStateSlotCheckerIntent());


            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, Cancelling"));
            RegisterIntentHandler(new DefaultStopIntentHandler("OK, Stopping"));
            RegisterIntentHandler(new DefaultSessionEndRequest("OK, Ending"));
            RegisterIntentHandler(new DefaultFallbackIntentHandler());
            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler());
        }
    }
}
