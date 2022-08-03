﻿using System.Text;
using AlexaNetCore;
using AlexaNetCore.Model;
using Slots.SupportingFiles;

namespace Slots.Intents
{
    internal class PhoneNumberSlotCheckerIntent: AlexaIntentHandlerBase
    {

        public PhoneNumberSlotCheckerIntent() : base(AlexaIntentType.Custom,SkillConstants.IntentNames.PhoneCheckerIntent)
        {
            AddSlot( SkillConstants.SlotNames.PhoneSlotName,AlexaBuiltInSlotTypes.PhoneNumber, true);
            AddSampleInvocation("Give me some phone numbers");
        }

        public override Task ProcessAsync()
        {
            try
            {
                var slotVal = GetAlexaSlot(SkillConstants.SlotNames.PhoneSlotName);
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

        private string AddSpaceBetweenEachLetter(string str)
        {
            var arr = str.ToCharArray();
            var result = String.Join(" ", arr);
            result = result.Replace(" - ", " dash ");  //this reads better coming from the Echo
            return result;
        }


    }
}
