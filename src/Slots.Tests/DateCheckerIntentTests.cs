
using AlexaNetCore;
using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.Slots.Tests
{
    public class DateCheckerIntentTests 
    {

        [Test]
        public async Task Spring()
        {
            var skill = await new SlotCheckerSkill()
                .LoadRequest(DateSlotCheckerQueries.Spring())
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000 )
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
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000 )
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
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(),  1000 )
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
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() , 1000)
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
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000 )
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
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000 )
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
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000 )
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
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000 )
                .ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.DateSlotChecker, skill.ChosenIntent.IntentName);
            var expectedVal = "I got 2 values including 2 0 2 2 dash 0 4 dash 0 1, and 2 0 2 2 dash 0 9 dash 0 5";
            Assert.AreEqual(expectedVal, skill.GetSpokenText());
        }

    }
}

