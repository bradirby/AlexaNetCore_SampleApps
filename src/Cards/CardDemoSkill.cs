using AlexaNetCore;

namespace AlexaNetCore.ZeroToHero.Cards
{
    public class CardDemoSkill : AlexaSkillBase
    {
        public CardDemoSkill()
        {
            SetSkillVersion("0.3.0");
            SetInvocationName("alexanetcore card demo");

            RegisterIntentHandler(new DefaultLaunchIntentHandler("Welcome to the card demo skill"));

            RegisterIntentHandler(new AddStandardCardIntent());
            RegisterIntentHandler(new AddSimpleCardIntent());

            RegisterIntentHandler(new DefaultFallbackIntentHandler());

            RegisterIntentHandler(new DefaultHelpIntentHandler("You can tell me to show you a card"));

            RegisterIntentHandler(new DefaultCancelIntentHandler());
            RegisterIntentHandler(new DefaultStopIntentHandler());
            RegisterIntentHandler(new DefaultSessionEndRequest());
            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler());

        }
    }
}
