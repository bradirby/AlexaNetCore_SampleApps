using AlexaNetCore.Model;
using AlexaNetCore.ZeroToHero.HelloWorld.SupportingFiles;

namespace AlexaNetCore.ZeroToHero.HelloWorld
{
    public class HelloWorldIntentHandler : AlexaIntentHandlerBase
    {
        public HelloWorldIntentHandler() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.HelloWorldIntentHandler)
        {
            AddSampleInvocation("Say Hello");
            AddSampleInvocation("Tell me hello");
            AddSampleInvocation("I want to hear you say hello");
        }

        public override Task ProcessAsync()
        {
            try
            {
                Speak($"Hello, you crazy world!");
                Reprompt("Are you still hanging on out there?");
            }
            catch (Exception)
            {
                Speak("I'm sorry, something went wrong.  Can you try again?");
            }
            return Task.CompletedTask;

        }
    }
}
