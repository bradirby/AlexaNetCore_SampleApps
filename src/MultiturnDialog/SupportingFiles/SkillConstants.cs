using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaNetCore.ZeroToHero.MultiturnDialog
{
    internal class SkillConstants
    {
        public class SlotNames
        {
            public static string TimeOfDay=> "timeOfDay";
            public static string Cuisine=> "cuisine";
            public static string Allergies=> "allergies";
            public static string Diet=> "diet";
            public static string Dish=> "dish";
            public static string Location=> "location";
            public static string Flavor=> "flavor";
        }

        public class SlotTypes
        {
            public static string TimeOfDay=> "timeOfDayType";
            public static string Cuisine=> "cuisineType";
            public static string Allergies=> "allergiesType";
            public static string Diet=> "dietType";
            public static string Location=> "locationType";
            public static string Flavor=> "flavorType";

        }

        public class RequestModifierNames
        {
        }


        public class IntentNames
        {
            public static string RecommendationIntent=> "RecommendationIntent";
            public static string LaunchHandler=> "MultiTurnDialogLaunchHandler";
            public static string PlanMyTrip => "PlanMyTrip";
        }

    }
}
