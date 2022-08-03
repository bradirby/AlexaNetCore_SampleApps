using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using Slots.SupportingFiles;

namespace Slots.Intents
{
    internal class FourDigitNumberIntent: AlexaIntentHandlerBase
    {

        public FourDigitNumberIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.FourDigitlotCheckerIntent)
        {
            AddSlot( SkillConstants.SlotNames.FourDigitNumSlotName,AlexaBuiltInSlotTypes.FourDigitNumber, false);
            AddSampleInvocation("Give me some four digit years");
        }

        public override Task ProcessAsync()
        {
            try
            {
                var slotVal = GetAlexaSlot(SkillConstants.SlotNames.FourDigitNumSlotName);
                if (slotVal.ContainsMultipleValues)
                {
                    var sb = new StringBuilder();
                    var connectorWord = "";
                    foreach (var oneOfManyValues in slotVal.Values)
                    {
                        sb.Append(connectorWord + AddSpaceBetweenEachLetter(oneOfManyValues.Value) );
                        connectorWord = ", and ";
                    }
                    Speak($"I got {slotVal.Values.Count} values including {sb.ToString()}");
                }
                else
                {
                    Speak($"I got the single value of {slotVal.Value}");
                }

            }
            catch (Exception )
            {
                Speak("Sorry, something went wrong.  Can you try again?");
            }

            KeepSessionActiveAfterResponse();
            return Task.CompletedTask;

        }

        private string AddSpaceBetweenEachLetter(string str)
        {
            var arr = str.ToCharArray();
            var result = String.Join(" ", arr);
            result = result.Replace(" - ", " dash ");  //this reads better coming from the Echo
            return result;
        }


    }
}
