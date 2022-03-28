using AlexaNetCore;
using DistanceLibrary;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace AlexaNetCoreSampleSkill.Intents
{
    public class HelloWorldIntentHandler : AlexaIntentHandlerBase
    {

        /// <summary>
        /// There is a default console logger built in which ties in with AWS logging.
        /// This logger can be replaced with any logger that implements IAlexaNetCoreMessageLogger if you would like to build your own.
        /// </summary>
        public HelloWorldIntentHandler() : base("SampleSkillIntent")
        {
        }

        public override void Process()
        {
            try
            {
                //no matter what the user said, we respond with Hello World
                ResponseEnv.SetOutputSpeechText("Hello World");
            }
            catch (Exception exc)
            {
                //Tell the user what is going on
                ResponseEnv.SetOutputSpeechText("I'm sorry, something went wrong.  Can you try again?");
            }

        }


    }
}
