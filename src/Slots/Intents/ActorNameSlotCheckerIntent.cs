using System.Text;
using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.Slots
{
    internal class ActorNameSlotCheckerIntent: AlexaIntentHandlerBase
    {

        public ActorNameSlotCheckerIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.ActorNameSlotChecker)
        {
            AddSlot( SkillConstants.SlotNames.ActorSlotName,AlexaBuiltInSlotTypes.ActorName, true);
            AddSampleInvocation("Give me Actor names");
        }

        public override Task ProcessAsync()
        {
            try
            {
                var slotVal = GetAlexaSlot(SkillConstants.SlotNames.ActorSlotName);
                if (slotVal.ContainsMultipleValues)
                {
                    var sb = new StringBuilder();
                    var connectorWord = "";
                    foreach (var alexaResponseSlotValue in slotVal.Values)
                    {
                        sb.Append(connectorWord + alexaResponseSlotValue.Value);
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


    }
}
