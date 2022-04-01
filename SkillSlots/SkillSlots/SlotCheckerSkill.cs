using System.Text;
using AlexaNetCore;
using Amazon.Lambda.Core;
using AlexaNetCore.InteractionModel;
using SlotChecker.Intents;

namespace SlotChecker
{
    public class SlotCheckerSkill: AlexaSkillBase
    {

        public SlotCheckerSkill() : base()
        {
            Init();
        }

        public SlotCheckerSkill(ILambdaLogger log) : base(log)
        {
            Init();
        }
        
        public SlotCheckerSkill(IAlexaNetCoreMessageLogger log) : base(log)
        {
            Init();
        }

        private void DefineCustomSlots()
        {

            AddCustomSlotType(new CustomSlotType("measureType")
                .AddValueOption("Inches", "inch")
                .AddValueOption("feet","foot")
                .AddValueOption("yards", "yard")
                .AddValueOption("miles","mile"));
        }

        private void Init()
        {
            DefineCustomSlots();
            SetSkillVersion("0.1");
            SetInvocationName("slot value checker");

            var fullHelpSb = new StringBuilder();
            fullHelpSb.Append("This skill is to help skill developers experiment with slots and slot types.  ");
            fullHelpSb.Append("It has many different intents, each with a different slot data type.  ");
            fullHelpSb.Append("Tell me what type of data you are working with, and some values and I will repeat back, character by character, what slot value your skill would have received.  ");
            fullHelpSb.Append("For example, if you are working with dates you can say,, Give me date values for tomorrow and friday,, or any other dates you like.  ");
            fullHelpSb.Append("I will read back the dates your skill slot would have received, character by character.  ");
            fullHelpSb.Append("All slots will accept multiple values.  ");
            fullHelpSb.Append("I can recognize many things , including dates and times, durations, numbers, phone numbers, ");
            fullHelpSb.Append("cities and states, actor names and more.  For full details on what this skill can do, visit the website at Alexa Net Core Dot com.  ");
            fullHelpSb.Append(", ,To get started now just say, , , give me date values for tomorrow and friday");


            var launchHelpSb = new StringBuilder();
            launchHelpSb.Append("Welcome to slot value checker - a tool to help you develop Alexa skills with slot values.  ");
            launchHelpSb.Append("Say,, give me date values for,, and then say one or more dates.  I will repeat back what I think you said.  ");
            launchHelpSb.Append("I recognize dates, times, numbers, phone numbers, city names, and more.");

            RegisterIntentHandler(new DefaultCancelIntentHandler("OK, Canceling slot checker"));
            RegisterIntentHandler(new DefaultStopIntentHandler("OK, Stopping slot checker"));
            RegisterIntentHandler(new DefaultHelpIntentHandler(fullHelpSb.ToString()));
            RegisterIntentHandler(new DefaultLaunchIntentHandler(launchHelpSb.ToString()));
            RegisterIntentHandler(new DefaultStartOverIntentHandler("From the top; Welcome to slot value checker"));
            RegisterIntentHandler(new DefaultNavigateHomeIntentHandler());
            RegisterIntentHandler(new DefaultFallbackIntentHandler("I didn't quite get that.  Can you try again?"));

            RegisterIntentHandler(new DateSlotCheckerIntent());
            RegisterIntentHandler(new DurationSlotCheckerIntent());
            RegisterIntentHandler(new FourDigitNumberSlotCheckerIntent());
            RegisterIntentHandler(new NumberSlotCheckerIntent());
            RegisterIntentHandler(new OrdinalSlotCheckerIntent());
            RegisterIntentHandler(new PhoneNumberSlotCheckerIntent());
            RegisterIntentHandler(new TimeSlotCheckerIntent());

            RegisterIntentHandler(new ActorNameSlotCheckerIntent());
            RegisterIntentHandler(new AnimalSlotCheckerIntent());
            RegisterIntentHandler(new USCitySlotCheckerIntent());
            RegisterIntentHandler(new USStateSlotCheckerIntent());
        }
    }
}
