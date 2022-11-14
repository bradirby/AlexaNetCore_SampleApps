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
                var slot = GetAlexaSlot(SkillConstants.SlotNames.MonthNameSlotName);
                Speak($"got the month name {slot.Value} with the key {slot.Value}");
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
