using AlexaNetCore.Directives;
using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.DynamicEntities;

public class GetCountyIntent : AlexaIntentHandlerBase
{
    public GetCountyIntent() : base(AlexaIntentType.Custom, SkillConstants.IntentNames.GetCountyIntent)
    {
        AddSampleInvocation($"i live in {{{SkillConstants.SlotNames.CountyName}}} county");

        AddSlot(new AlexaSlot(SkillConstants.SlotNames.CountyName, SkillConstants.SlotTypes.CountyName, false));

    }

    public override Task ProcessAsync()
    {
        try
        {
            var stateName = GetRequestSessionValue(SkillConstants.SessionVarNames.StateName, "unknown");


            KeepSessionActiveAfterResponse();
            var countyName = GetSlotValue(SkillConstants.SlotNames.CountyName);

            var txt = $"OK, I see you live in the state {stateName} and county {countyName}.";
            Speak(txt);
            AddCard("State", txt);

        }
        catch (Exception )
        {
            Speak("Sorry, something went wrong.  Please try again.");
        }
        return Task.CompletedTask;

    }

}