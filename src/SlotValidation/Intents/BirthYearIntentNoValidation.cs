using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using SlotValidation.SupportingFiles;

namespace SlotValidation.Intents
{
    internal class BirthYearIntentNoValidation : AlexaIntentHandlerBase
    {
        public BirthYearIntentNoValidation() : base(AlexaIntentType.Custom, SkillConstants.IntentNames.BirthYearNoValidation)
        {
            AddSlot(SkillConstants.SlotNames.FourDigitNumSlotName, AlexaBuiltInSlotTypes.FourDigitNumber, false);

            AddSampleInvocation($"I was born in the year {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
            AddSampleInvocation($"I was born in {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
            AddSampleInvocation($"My birth year was {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)}");
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
