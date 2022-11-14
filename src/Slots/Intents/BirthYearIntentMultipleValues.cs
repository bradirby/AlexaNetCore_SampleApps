using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using Slots.SupportingFiles;

namespace Slots.Intents
{
    internal class BirthYearIntentMultipleValues : AlexaIntentHandlerBase
    {
        public BirthYearIntentMultipleValues() : base(AlexaIntentType.Custom, SkillConstants.IntentNames.BirthYearMultipleValues)
        {
            AddSlot(SkillConstants.SlotNames.FourDigitNumSlotName, AlexaBuiltInSlotTypes.FourDigitNumber, true);
            AddSampleInvocation($"My kids were born in the year {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
            AddSampleInvocation($"My kids were born in {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
            AddSampleInvocation($"My kids birth years were {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
        }

        private string AddBraces(string str) => $"{{{str}}}";

        public override Task ProcessAsync()
        {
            KeepSessionActiveAfterResponse();
            try
            {
                var slot = GetAlexaSlot(SkillConstants.SlotNames.FourDigitNumSlotName);

                if (slot == null)
                {
                    Speak("got null slot value");
                    return Task.CompletedTask;
                }

                if (slot.ContainsMultipleValues)
                {
                    var sb = new StringBuilder();
                    var connectorWord = "";
                    foreach (var oneOfManyValues in slot.Values)
                    {
                        sb.Append(connectorWord + oneOfManyValues);
                        connectorWord = ", and ";
                    }

                    Speak($"I got {slot.Value.ToList().Count} values including {sb}");
                }
                else
                {
                    Speak($"I got the single value of {slot.Value}");
                }

            }
            catch (Exception)
            {
                Speak("Sorry, something went wrong.  Can you try again?");
            }

            return Task.CompletedTask;
        }



    }
}
