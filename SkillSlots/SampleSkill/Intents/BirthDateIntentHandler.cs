using AlexaNetCore;
using System;

namespace SkillSlots.Intents
{
    public class BirthDateIntentHandler : AlexaIntentHandlerBase
    {

        public BirthDateIntentHandler() : base("BirthDateIntent")
        {
            AddSlotOption("bday", "AMAZON.DATE");

            AddSampleInvocation("My birthday is {bday}");
            AddSampleInvocation("I was born on {bday}");
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
