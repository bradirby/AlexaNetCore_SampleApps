using System.Text;
using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.CustomSlots
{
    internal class MonthNameIntent: AlexaIntentHandlerBase
    {

        public MonthNameIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.MonthNameIntent)
        {
            AddSlot( SkillConstants.SlotNames.MonthNameSlotName, SkillConstants.SlotTypes.MonthNameSlotType, false);
            AddSampleInvocation("Is a month name");
        }

        public override Task ProcessAsync()
        {
            try
            {
                var slotVal = GetAlexaSlot(SkillConstants.SlotNames.MonthNameSlotName);
                Speak($"got the month name {slotVal.Value} with the key {slotVal.Id}");
            }
            catch (Exception )
            {
                Speak("sorry, something went wrong");
            }

            KeepSessionActiveAfterResponse();
            return Task.CompletedTask;

        }

    }
}
