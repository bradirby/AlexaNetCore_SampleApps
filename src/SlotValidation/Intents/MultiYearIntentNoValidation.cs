using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using SlotValidation.SupportingFiles;

namespace SlotValidation.Intents
{
    internal class MultiYearIntentNoValidation : AlexaIntentHandlerBase
    {
        public MultiYearIntentNoValidation() : base(AlexaIntentType.Custom, SkillConstants.IntentNames.MultiYearNoValidation)
        {
            AddSlot(SkillConstants.SlotNames.FourDigitNumSlotName, AlexaBuiltInSlotTypes.FourDigitNumber, true);

            AddSampleInvocation($"My kids were born in the years {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
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
