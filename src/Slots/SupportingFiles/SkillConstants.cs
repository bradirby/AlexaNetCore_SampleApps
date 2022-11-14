namespace Slots.SupportingFiles
{
    /// <summary>
    /// A constant class that keeps all the slot names.
    /// Since slot names must be unique across the whole skill, it is best to keep them all in one place
    /// </summary>
    public static class SkillConstants
    {
        public class SlotNames
        {
            public static string FourDigitNumSlotName => "fourDigitNumSlot";
            public static string ActorSlotName => "actorNameValue";
            public static string AnimalSlotName => "animalNameValue";
            public static string DateSlotName => "dateSlot";
            public static string DurationSlotName => "durationInputValue";
            public static string NumberSlotName => "numberInputValue";
            public static string OrdinalSlotName => "ordinalInputValue";
            public static string PhoneSlotName => "phoneInputValue";
            public static string TimeSlotName => "timeInputValue";
            public static string USCitySlotName => "timeInputValue";
            public static string USStateSlotName => "stateNameValue";
        }

        public class IntentNames
        {
            public static string ActorNameSlotChecker => "actorNameSlotCheckerIntent";
            public static string AnimalSlotCheckerIntent => "AnimalSlotCheckerIntent";
            public static string BirthYear=> "BirthYearIntent";
            public static string BirthYearMultipleValues => "BirthYearMultipleValues";
            public static string DateSlotChecker => "DateSlotCheckerIntent";
            public static string DurationSlotCheckerIntent => "DurationSlotCheckerIntent";
            public static string FourDigitlotCheckerIntent => "FourDigitNumberSlotCheckerIntent";
            public static string NumberCheckerIntent => "NumberSlotCheckerIntent";
            public static string OrdinalCheckerIntent => "OrdinalSlotCheckerIntent";
            public static string PhoneCheckerIntent => "PhoneNumberSlotCheckerIntent";
            public static string TimeCheckerIntent => "TimeSlotCheckerIntent";
            public static string USCityCheckerIntent => "USCityCheckerIntent";
            public static string USStateCheckerIntent => "USStateSlotCheckerIntent";
        }

    }
}
