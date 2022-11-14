using AlexaNetCore.Directives;
using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.DynamicEntities;

public class GetStateIntent : AlexaIntentHandlerBase
{
    public GetStateIntent() : base(AlexaIntentType.Custom, SkillConstants.IntentNames.GetStateIntent)
    {
        AddSampleInvocation($"My state is {{{SkillConstants.SlotNames.StateName}}}");

        AddSlot(new AlexaSlot(SkillConstants.SlotNames.StateName, SkillConstants.SlotTypes.StateName, false)
        .AddSlotValidation(new AlexaSlotValidationIsInSet<string>("The state you mentioned is stupid")
            .AddSetItem("California")
            .AddSetItem("Virginia")
            .AddSetItem("Florida"))
        .MakeSlotRequired(new AlexaRequiredSlot("I'm sorry, I didn't catch that. I only support California, Virginia, and Florida. What was the state name again?")
            .AddUserUtterance($"i told you it is {{{SkillConstants.SlotNames.StateName}}}")
            .AddMissingValuePromptVariation("That is not in my list of supported states of California, Virginia, and Florida. Can you make another choice?")
            .AddMissingValuePromptVariation("I can't find that state. I only support California, Virginia, and Florida. Can you try again?")));

    }

    public override Task ProcessAsync()
    {
        try
        {
            KeepSessionActiveAfterResponse();
            var stateName = GetSlotValue(SkillConstants.SlotNames.StateName);

            var txt = $"OK, I see you live in the state {stateName}.  Now tell me the county";
            SetSessionValue(SkillConstants.SessionVarNames.StateName, stateName);
            Speak(txt);
            AddCard("State", txt);

            UpdateDynamicEntities(new AlexaSlotUpdate(SkillConstants.SlotNames.CountyName)    
                    .AddSlotOption(new AlexaSlotUpdateOption($"{stateName} county one").AddSynonym("one"))
                    .AddSlotOption(new AlexaSlotUpdateOption($"{stateName} county two").AddSynonym("two"))
                    .AddSlotOption(new AlexaSlotUpdateOption($"{stateName} county three").AddSynonym("three")));

        }
        catch (Exception )
        {
            Speak("Sorry, something went wrong.  Please try again.");
        }
        return Task.CompletedTask;
    }

}