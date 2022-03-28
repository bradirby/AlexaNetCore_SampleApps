using AlexaNetCore;
using DistanceLibrary;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace UnitTestingSkill.Intents
{
    public class NetCoreBirthDateIntentHandler : AlexaIntentHandlerBase
    {

        /// <summary>
        /// There is a default console logger built in which ties in with AWS logging.
        /// This logger can be replaced with any logger that implements IAlexaNetCoreMessageLogger if you would like to build your own.
        /// </summary>
        public NetCoreBirthDateIntentHandler() : base("SampleSkillIntent")
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
