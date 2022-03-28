using AlexaNetCore;

namespace AlexaNetCoreGettingStarted.Intents
{
    public class NetCoreBirthDateIntentHandler : AlexaIntentHandlerBase
    {
        public NetCoreBirthDateIntentHandler() : base("NetCoreBirthDateIntent")
        {
        }

        public override void Process()
        {
            try
            {
                var numDaysOld = (DateTime.Today - new DateTime(2016, 6, 27)).TotalDays;
                ResponseEnv.SetOutputSpeechText($"Dot Net Core is {numDaysOld} days old today");
            }
            catch (Exception)
            {
                ResponseEnv.SetOutputSpeechText("I'm sorry, something went wrong.  Can you try again?");
            }

        }
    }
}
