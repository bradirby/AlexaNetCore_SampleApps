using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.Internationalization
{
    public class IntlIntentHandler : AlexaIntentHandlerBase
    {
        public IntlIntentHandler() : base(AlexaIntentType.Custom,"IntlIntentHandler")
        {
            AddSampleInvocation(Translations.IntentInvocations.CanYouSpeakInEglish);
        }

        public override Task ProcessAsync()
        {
            try
            {
                Speak(Translations.IntentPrompts.YesICanSpeakYourLanguage);
            }
            catch (Exception)
            {
                Speak(Translations.IntentPrompts.SomethingWentWrong);
            }
            return Task.CompletedTask;

        }
    }
}
