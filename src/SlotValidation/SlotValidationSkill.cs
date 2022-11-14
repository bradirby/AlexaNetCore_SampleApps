using AlexaNetCore;
using Microsoft.Extensions.Logging;
using SlotValidation.Intents;

namespace SlotValidation
{
    public class SlotValidationSkill : AlexaSkillBase
    {
        public SlotValidationSkill(ILoggerFactory loggerFactory):base(loggerFactory)
        {
            SetSkillVersion("0.3.0");
            SetInvocationName("alexanetcore slot validation");


            RegisterIntentHandler(new DefaultLaunchIntentHandler("Welcome to the slot validation project"));



            RegisterIntentHandler(new BirthYearIntentNoValidation());
            RegisterIntentHandler(new BirthYearIntentWithValidation());
            RegisterIntentHandler(new MultiYearIntentWithValidation());
            RegisterIntentHandler(new MultiYearIntentNoValidation());

            RegisterIntentHandler(new BirthYearRequiredIntentNoValidation());


            RegisterIntentHandler(new DefaultHelpIntentHandler(""));
            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, Cancelling"));
            RegisterIntentHandler(new DefaultStopIntentHandler("OK, Stopping"));
            RegisterIntentHandler(new DefaultSessionEndRequest("OK, Ending"));
            RegisterIntentHandler(new DefaultFallbackIntentHandler());
            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler());
        }
    }
}
