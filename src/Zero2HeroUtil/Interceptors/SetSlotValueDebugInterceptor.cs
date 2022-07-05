using AlexaNetCore.Interfaces;
using AlexaNetCore.RequestModel;

namespace AlexaNetCore.ZeroToHero.Util;


/// <summary>
/// This interceptor is for use in debug to set the incoming userid to a specific property for testing
/// </summary>
public class SetSlotValueDebugInterceptor: IAlexaRequestInterceptor
{
    private string SlotVal;
    private string SlotName;

    public SetSlotValueDebugInterceptor(string slotName, string slotVal)
    {
        SlotVal = slotVal;
        SlotName = slotName;
    }

    public Task<AlexaRequestEnvelope> ProcessAsync(AlexaRequestEnvelope reqEnv)
    {
        reqEnv.SetSlotValue(SlotName, SlotVal);
        return Task.FromResult(reqEnv);
    }

}