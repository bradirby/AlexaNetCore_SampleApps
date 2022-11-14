using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using SlotValidation.SupportingFiles;

namespace SlotValidation.Intents
{
    internal class MultiYearIntentWithValidation : AlexaIntentHandlerBase
    {
        public MultiYearIntentWithValidation() : base(AlexaIntentType.Custom, SkillConstants.IntentNames.MultiYearWithValidation)
        {
            AddSlot(SkillConstants.SlotNames.FourDigitNumSlotName, AlexaBuiltInSlotTypes.FourDigitNumber, true)
                .AddSlotValidation(new AlexaSlotValidationIsInSet<int>(new [] {1950,1960},
                    "Sorry, all of the years must be 1950 or 1960.  Try again"));

            AddSampleInvocation($"Verify all of the years {AddBraces(SkillConstants.SlotNames.FourDigitNumSlotName)} ");
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
