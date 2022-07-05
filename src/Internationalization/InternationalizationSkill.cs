using AlexaNetCore;

namespace AlexaNetCore.ZeroToHero.Internationalization
{
    public class InternationalizationSkill : AlexaSkillBase
    {
        public InternationalizationSkill()
        {
            SetSkillVersion("0.2.0");
            SetInvocationName(Translations.SkillInvocation);

            RegisterIntentHandler(new DefaultLaunchIntentHandler(
                Translations.IntentPrompts.LaunchHandlerGreeting, 
                Translations.IntentPrompts.LaunchHandlerReprompt));

            RegisterIntentHandler(new IntlIntentHandler());


            RegisterIntentHandler(new DefaultHelpIntentHandler(
                Translations.IntentPrompts.HelpHandlerText, 
                Translations.IntentPrompts.HelpHandlerReprompt));

            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler(Translations.IntentPrompts.EndSessionText));
            RegisterIntentHandler(new DefaultCancelIntentHandler(Translations.IntentPrompts.EndSessionText));
            RegisterIntentHandler(new DefaultStopIntentHandler(Translations.IntentPrompts.EndSessionText));
            RegisterIntentHandler(new DefaultSessionEndRequest(Translations.IntentPrompts.EndSessionText));

            RegisterIntentHandler(new DefaultFallbackIntentHandler(Translations.IntentPrompts.EndSessionText));
        }


    }
}
