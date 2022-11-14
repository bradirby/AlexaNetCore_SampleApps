using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.Session;

internal class SetSessionValueIntent: AlexaIntentHandlerBase
{

    public SetSessionValueIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.SetSessionValueIntent)
    {
        AddSlot(SkillConstants.SlotNames.ActorName, AlexaBuiltInSlotTypes.ActorName, false);

        AddSampleInvocation($"My favorite actor is {SkillConstants.SlotNames.ActorName}");
        AddSampleInvocation($"I Love {SkillConstants.SlotNames.ActorName}");
        AddSampleInvocation($"I always see movies with {SkillConstants.SlotNames.ActorName}");
    }

    public override Task ProcessAsync()
    {
        try
        {
            var actorName = GetSlotValue(SkillConstants.SlotNames.ActorName,  "unknown");
            SetSessionValue(SkillConstants.SessionValueNames.ActorName, actorName);
            Speak($"Saving your actor name of {actorName}");
        }
        catch (Exception )
        {
            Speak("Sorry, something went wrong");
        }

        KeepSessionActiveAfterResponse();
        return Task.CompletedTask;

    }

}