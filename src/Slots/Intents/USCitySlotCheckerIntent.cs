using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using Slots.SupportingFiles;

namespace Slots.Intents
{
    internal class USCitySlotCheckerIntent: AlexaIntentHandlerBase
    {

        public USCitySlotCheckerIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.USCityCheckerIntent)
        {
            AddSlot( SkillConstants.SlotNames.USCitySlotName,AlexaBuiltInSlotTypes.USCity, true);
            AddSampleInvocation("give me some U S Cities");
        }

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
