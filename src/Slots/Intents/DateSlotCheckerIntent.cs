﻿using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using Slots.SupportingFiles;

namespace Slots.Intents
{
    internal class DateSlotIntent: AlexaIntentHandlerBase
    {

        public DateSlotIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.DateSlotChecker)
        {
            AddSlot(SkillConstants.SlotNames.DateSlotName, AlexaBuiltInSlotTypes.Date, true);
            AddSampleInvocation("Give me some dates");
        }

        public override Task ProcessAsync()
        {
            try
            {
                var slotVal = GetAlexaSlot(SkillConstants.SlotNames.DateSlotName);
                if (slotVal.ContainsMultipleValues)
                {
                    var sb = new StringBuilder();
                    var connectorWord = "";
                    foreach (var alexaResponseSlotValue in slotVal.Values)
                    {
                        sb.Append(connectorWord + AddSpaceBetweenEachLetter(alexaResponseSlotValue.Value) );
                        connectorWord = ", and ";
                    }
                    Speak($"I got {slotVal.Values.Count} values including {sb.ToString()}");
                }
                else
                {
                    Speak($"I got the single value of {AddSpaceBetweenEachLetter(slotVal.Value)}");
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
