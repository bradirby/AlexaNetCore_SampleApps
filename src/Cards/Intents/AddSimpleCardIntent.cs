using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.Cards;

internal class AddSimpleCardIntent: AlexaIntentHandlerBase
{

    public AddSimpleCardIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.SimpleCardIntentName)
    {
        AddSampleInvocation("Show me a card");
        AddSampleInvocation("I want to see a card");
        AddSampleInvocation("Give me a card");
        AddSampleInvocation("Show me something");
    }

    public override Task ProcessAsync()
    {
        try
        {
            AddCard("Simple Card Title", "I have no image, just this text");

            Speak("Check your screen for the simple card I added.  It has no image, just text");
        }
        catch (Exception )
        {
            Speak("Sorry, something went wrong");
        }

        KeepSessionActiveAfterResponse();
        return Task.CompletedTask;

    }

}