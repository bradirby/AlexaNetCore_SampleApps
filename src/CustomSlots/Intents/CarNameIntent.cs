using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.CustomSlots;

internal class CarNameIntent: AlexaIntentHandlerBase
{

    public CarNameIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.CarNameIntent)
    {
        AddSlot( SkillConstants.SlotNames.CarNameSlotName, SkillConstants.SlotTypes.CarNameSlotType, false);
        AddSampleInvocation("Give me the name of a car");
        AddSampleInvocation("Name a car");
        AddSampleInvocation("What is your favorite car");
        AddSampleInvocation("What was your first car");
    }

    public override Task ProcessAsync()
    {
        try
        {
            var slotVal = GetAlexaSlot(SkillConstants.SlotNames.CarNameSlotName);
            Speak($"You really like the car {slotVal.Value}");
        }
        catch (Exception )
        {
            Speak("Sorry, something went wrong");
        }

        KeepSessionActiveAfterResponse();
        return Task.CompletedTask;

    }



}