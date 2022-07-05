using System.Text;
using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.Cards
{
    internal class AddStandardCardIntent: AlexaIntentHandlerBase
    {

        public AddStandardCardIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.StandardCardIntentName)
        {
            AddSampleInvocation("Show me a standard card");
            AddSampleInvocation("Show me a card with an image");
            AddSampleInvocation("I want to see an image");
            AddSampleInvocation("Show me the image");
        }

        public override Task ProcessAsync()
        {
            try
            {
                var imgLink = new AlexaImageLink("https://exactmeasurebucket.s3.amazonaws.com/Small.png"
                        ,"https://exactmeasurebucket.s3.amazonaws.com/Large.png");

                AddCard("Standard Card Title", "There should be in image below", imgLink);

                Speak("Check your screen for the standard card I added.  There should also be an image.");
            }
            catch (Exception )
            {
                Speak("I'm sorry, something went wrong");
            }

            KeepSessionActiveAfterResponse();
            return Task.CompletedTask;

        }

    }
}
