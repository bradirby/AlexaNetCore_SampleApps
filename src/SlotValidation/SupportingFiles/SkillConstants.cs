namespace SlotValidation.SupportingFiles
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
        }

        public class IntentNames
        {
            public static string MultiYearNoValidation=> "MultiYearNoValidation";
            public static string MultiYearWithValidation => "MultiYearWithValidation";
            public static string BirthYearNoValidation => "BirthYearNoValidation";
            public static string BirthYearRequiredNoValidation => "BirthYearRequiredNoValidation";
            public static string BirthYearWithValidation => "BirthYearIntentWithValidation";
        }

    }
}
