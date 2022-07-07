using AlexaNetCore.Model;
using AlexaNetCore.ZeroToHero.HelloWorld.SupportingFiles;

namespace AlexaNetCore.ZeroToHero.HelloWorld
{
    public class HelloWorldIntentHandler : AlexaIntentHandlerBase
    {
        public HelloWorldIntentHandler() : base(AlexaIntentType.Custom,"HelloWorldIntentHandler")
        {
            AddSampleInvocation("How old is Dot Net Core");
            AddSampleInvocation("When was Dot Net Core born");
        }

        public override Task ProcessAsync()
        {
            try
            {
                var numDaysOld = (DateTime.Today - new DateTime(2016, 6, 27)).TotalDays;
                Speak($"Dot Net Core is {numDaysOld} days old today");
            }
            catch (Exception)
            {
                Speak("I'm sorry, something went wrong.  Can you try again?");
            }
            return Task.CompletedTask;

        }
    }
}
