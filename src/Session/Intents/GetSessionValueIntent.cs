using System.Text;
using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.Session
{
    internal class GetSessionValueIntent: AlexaIntentHandlerBase
    {

        public GetSessionValueIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.GetSessionValueIntent)
        {
            AddSampleInvocation("Tell me what my favorite actor is");
            AddSampleInvocation("Who is my favorite actor");
            AddSampleInvocation("Can you guess my favorite actor?");
        }

        public override Task ProcessAsync()
        {
            try
            {
                var actorName = GetRequestSessionValue(SkillConstants.SessionValueNames.ActorName, "");
                if (actorName == "") Speak("I could not find your favorite actor name");
                else Speak($"Your favorite actor is {actorName}");
            }
            catch (Exception )
            {
                Speak("Sorry, something went wrong");
            }

            KeepSessionActiveAfterResponse();
            return Task.CompletedTask;

        }

    }
}
