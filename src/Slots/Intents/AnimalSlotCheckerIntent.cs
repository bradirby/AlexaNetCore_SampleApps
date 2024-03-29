﻿using System.Text;
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
            try
            {
                var slotVal = GetAlexaSlot(SkillConstants.SlotNames.AnimalSlotName);
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
