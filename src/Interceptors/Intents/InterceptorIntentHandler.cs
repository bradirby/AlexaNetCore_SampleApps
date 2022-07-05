using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.Interceptors
{
    public class InterceptorIntentHandler : AlexaIntentHandlerBase
    {
        public InterceptorIntentHandler() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.InterceptIntent)
        {
            AddSampleInvocation("Is the interceptor active");
        }

        public override Task ProcessAsync()
        {
            try
            {
                var usrName = RequestEnv.GetSessionAttribute(SkillConstants.SessionAttributeNames.Username, "unknown");
                Speak($"The interceptor is intercepting and found the user {usrName}");
            }
            catch (Exception)
            {
                Speak("I'm sorry, something went wrong.  Can you try again?");
            }
            return Task.CompletedTask;

        }
    }
}
