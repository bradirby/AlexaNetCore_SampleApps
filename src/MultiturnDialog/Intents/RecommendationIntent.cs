using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.MultiturnDialog;

public class RecommendationIntent : AlexaIntentHandlerBase
{
    public RecommendationIntent() : base(AlexaIntentType.Custom, SkillConstants.IntentNames.RecommendationIntent)
    {
        AddSampleInvocation($"It's {{{SkillConstants.SlotNames.TimeOfDay}}} time");
        AddSampleInvocation($"It's {{{SkillConstants.SlotNames.TimeOfDay}}}");
        AddSampleInvocation("I want something savory and spicy");
        AddSampleInvocation("Korean sounds great");
        AddSampleInvocation("I'm allergic to shellfish and I'm pescatarian");
        AddSampleInvocation("Me un tang sounds great");
        AddSampleInvocation("I want to get out of the office");
        AddSampleInvocation("Seattle Washington");
        AddSampleInvocation("korean bamboo");

        RequireConfirmation(new AlexaRequiredIntentSettings()
            .AddPromptVariation("Are you sure you want to go with this?"));

        AddSlot(new AlexaSlot(SkillConstants.SlotNames.TimeOfDay, SkillConstants.SlotTypes.TimeOfDay, false)
            .MakeSlotRequired(new AlexaRequiredSlot()
                .AddMissingValuePromptVariation("When did you want to eat?")
                .AddMissingValuePromptVariation("Is this breakfast, lunch, or dinner?")
                .AddUserUtterance($"I want {{{SkillConstants.SlotNames.TimeOfDay}}}")
                .AddUserUtterance($"I'm jonesing for {{{SkillConstants.SlotNames.TimeOfDay}}}"))
            .SetSlotOrder(1));

        AddSlot(new AlexaSlot(SkillConstants.SlotNames.Allergies, SkillConstants.SlotTypes.Allergies, true)
            .MakeSlotRequired(new AlexaRequiredSlot()
                .AddMissingValuePromptVariation("Do you have allergies?")
                .AddMissingValuePromptVariation("Is there anything we should avoid?")
                .AddUserUtterance($"I am allergic to {{{SkillConstants.SlotNames.Allergies}}} ")
                .AddUserUtterance($"I suffer from an allergy to {{{SkillConstants.SlotNames.Allergies}}}"))
            .SetSlotOrder(2));

        AddSlot(new AlexaSlot(SkillConstants.SlotNames.Cuisine, SkillConstants.SlotTypes.Cuisine, false)
            .MakeSlotRequired(new AlexaRequiredSlot()
                .AddMissingValuePromptVariation("I didn't get the cuisine")
                .AddMissingValuePromptVariation("gimme a cuisine")
                .AddUserUtterance($"I want {{{SkillConstants.SlotNames.Cuisine}}}")
                .AddUserUtterance($"gimme something {{{SkillConstants.SlotNames.Cuisine}}}"))
            .SetSlotOrder(3));

        AddSlot(new AlexaSlot(SkillConstants.SlotNames.Dish, AlexaBuiltInSlotTypes.Food, false)
            .MakeSlotRequired(new AlexaRequiredSlot()
                .AddMissingValuePromptVariation("What type of food do you like")
                .AddMissingValuePromptVariation("What are you in the mood for?")
                .AddMissingValuePromptVariation("And what are we eating today?")
                .AddUserUtterance($"I want {{{SkillConstants.SlotNames.Dish}}}")
                .AddUserUtterance($"I'm in the mood for {{{SkillConstants.SlotNames.Dish}}}"))
            .SetSlotOrder(4));
    }

    public override Task ProcessAsync()
    {
        try
        {
            KeepSessionActiveAfterResponse();
            if (IntentConfirmationStatus != "CONFIRMED")
            {
                Speak("sorry, I guess I didn't understand.  Let's try again");
            }
            else
            {
                var timeOfDay = GetSlotValue(SkillConstants.SlotNames.TimeOfDay);
                var cuisine = GetSlotValue(SkillConstants.SlotNames.Cuisine);
                var food = GetSlotValue(SkillConstants.SlotNames.Dish);

                var allergyTxt = GetSpokenAllergyText();
                var txt = $"OK, I see we are having {food} for {timeOfDay}{allergyTxt} and make it {cuisine}";
                Speak(txt);
                AddCard("Menu", txt);
            }
        }
        catch (Exception )
        {
            Speak("Sorry, something went wrong in the kitchen.  Please try again.");
        }
        return Task.CompletedTask;
    }

    private string GetSpokenAllergyText()
    {
        var allergySlot = GetSlot(SkillConstants.SlotNames.Allergies);
        var matchedAllergy = allergySlot.MatchedValues.FirstOrDefault();
        if (matchedAllergy != null)
        {
            if (matchedAllergy.Value.Id == "NONE") return "";
            return $", but no {matchedAllergy.Value.Name}";
        }

        //didn't match one of our specified values, to repeat what they said
        if (allergySlot.SpokenValue == "") return "";
        return $", but no {allergySlot.SpokenValue}, ";

    }
}