using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using Slots.SupportingFiles;

namespace Slots.Intents
{
    internal class BirthYearIntent : AlexaIntentHandlerBase
    {
        public BirthYearIntent() : base(AlexaIntentType.Custom, SkillConstants.IntentNames.BirthYear)
        {
            AddSlot(SkillConstants.SlotNames.FourDigitNumSlotName, AlexaBuiltInSlotTypes.FourDigitNumber, false);
            AddSampleInvocation($"I was born in the year {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
            AddSampleInvocation($"I was born in {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
            AddSampleInvocation($"My birth year was {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
        }

        private string AddBraces(string str) => $"{{{str}}}";

        public override Task ProcessAsync()
        {
            try
            {
                var slotVal = GetAlexaSlot(SkillConstants.SlotNames.FourDigitNumSlotName);
                Speak($"I got the single value of {slotVal.Value}");
            }
            catch (Exception)
            {
                Speak("Sorry, something went wrong.  Can you try again?");
            }

            KeepSessionActiveAfterResponse();
            return Task.CompletedTask;

        }



    }
}
