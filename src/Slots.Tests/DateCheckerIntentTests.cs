﻿using System.Threading.Tasks;
using NUnit.Framework;
using Slots.SupportingFiles;
using Slots.Tests.TestData;

namespace Slots.Tests
{
    public class DateCheckerIntentTests 
    {

        [Test]
        public async Task Spring()
        {
            var skill = await new SlotCheckerSkill()
                .LoadRequest(DateSlotCheckerQueries.Spring())
                .ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.DateSlotChecker, skill.ChosenIntent.IntentName);
            var expectedVal = "I got the single value of 2 0 2 2 dash S P";  //asked on 1 april 2022
            Assert.AreEqual(expectedVal, skill.GetSpokenText());
        }

        [Test]
        public async Task NineteenNineties()
        {
            var skill = await new SlotCheckerSkill()
                .LoadRequest(DateSlotCheckerQueries.NineteenNineties())
                .ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.DateSlotChecker, skill.ChosenIntent.IntentName);
            var expectedVal = "I got the single value of 1 9 9 X";  //asked on 1 april 2022
            Assert.AreEqual(expectedVal, skill.GetSpokenText());
        }

        [Test]
        public async Task ThisYear()
        {
            var skill = await new SlotCheckerSkill()
                .LoadRequest(DateSlotCheckerQueries.ThisYear())
                .ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.DateSlotChecker, skill.ChosenIntent.IntentName);
            var expectedVal = "I got the single value of 2 0 2 2";  //asked on 1 april 2022
            Assert.AreEqual(expectedVal, skill.GetSpokenText());
        }

        [Test]
        public async Task January()
        {
            var skill = await new SlotCheckerSkill()
                .LoadRequest(DateSlotCheckerQueries.January())
                .ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.DateSlotChecker, skill.ChosenIntent.IntentName);
            var expectedVal = "I got the single value of 2 0 2 3 dash 0 1";  //asked on 1 april 2022
            Assert.AreEqual(expectedVal, skill.GetSpokenText());
        }

        [Test]
        public async Task NextWeekend()
        {
            var skill = await new SlotCheckerSkill()
                .LoadRequest(DateSlotCheckerQueries.NextWeekEnd())
                .ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.DateSlotChecker, skill.ChosenIntent.IntentName);
            var expectedVal = "I got the single value of 2 0 2 2 dash W 1 4 dash W E";  //asked on 1 april 2022
            Assert.AreEqual(expectedVal, skill.GetSpokenText());
        }

        [Test]
        public async Task ThisWeek()
        {
            var skill = await new SlotCheckerSkill()
                .LoadRequest(DateSlotCheckerQueries.AskForThisWeek())
                .ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.DateSlotChecker, skill.ChosenIntent.IntentName);
            var expectedVal = "I got the single value of 2 0 2 2 dash W 1 3";  //asked on 1 april 2022
            Assert.AreEqual(expectedVal, skill.GetSpokenText());
        }

        [Test]
        public async Task SingleStandardDate()
        {
            //what date values do you get for april 4 as your input value
            var skill = await new SlotCheckerSkill()
                .LoadRequest(DateSlotCheckerQueries.AskForAprilFourth())
                .ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.DateSlotChecker, skill.ChosenIntent.IntentName);
            var expectedVal = "I got the single value of 2 0 2 2 dash 0 4 dash 0 4";
            Assert.AreEqual(expectedVal, skill.GetSpokenText());
        }

        [Test]
        public async Task MultipleStandardDates()
        {
            //what date values do you get for april 4 as your input value
            var skill = await new SlotCheckerSkill()
                .LoadRequest(DateSlotCheckerQueries.AskForAprilFirstAndSeptemberFifth())
                .ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.DateSlotChecker, skill.ChosenIntent.IntentName);
            var expectedVal = "I got 2 values including 2 0 2 2 dash 0 4 dash 0 1, and 2 0 2 2 dash 0 9 dash 0 5";
            Assert.AreEqual(expectedVal, skill.GetSpokenText());
        }

    }
}

