using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using Slots.SupportingFiles;

namespace Slots.Intents
{
    internal class AnimalSlotCheckerIntent: AlexaIntentHandlerBase
    {

        public AnimalSlotCheckerIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.AnimalSlotCheckerIntent)
        {
            AddSlot( SkillConstants.SlotNames.AnimalSlotName,AlexaBuiltInSlotTypes.Animal, true);
            AddSampleInvocation("Give me some animal names");
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
