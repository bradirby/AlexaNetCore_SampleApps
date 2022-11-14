using NUnit.Framework;
using System.Threading.Tasks;
using Cards.Tests.Interceptors;
using Microsoft.Extensions.Logging;

namespace AlexaNetCore.ZeroToHero.Cards.Tests
{
    internal class AddSimpleCardIntentTest
    {

        [Test]
        public async Task CorrectIntentExecuted()
        {
            var skill = new CardDemoSkill(new LoggerFactory());
            skill.LoadRequest(CardDemoInvocationQueries.SimpleCardIntentQuery);
            skill.RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() );
            await skill.ProcessRequestAsync();

            Assert.AreEqual(SkillConstants.IntentNames.SimpleCardIntentName, skill.ChosenIntent.IntentName);
        }

        [Test]
        public async Task CorrectSpokenTextReturned()
        {
            var skill = await new CardDemoSkill(new LoggerFactory())
                .LoadRequest(CardDemoInvocationQueries.SimpleCardIntentQuery)
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() )
                .ProcessRequestAsync();

            Assert.AreEqual("Check your screen for the simple card I added.  It has no image, just text", skill.GetSpokenText());
        }

        [Test]
        public async Task CardExists()
        {
            var skill = await new CardDemoSkill(new LoggerFactory())
                .LoadRequest(CardDemoInvocationQueries.SimpleCardIntentQuery)
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() )
                .ProcessRequestAsync();

            Assert.IsNotNull(skill.GetCard());
        }

        [Test]
        public async Task CardTitleCorrect()
        {
            var skill = await new CardDemoSkill(new LoggerFactory())
                .LoadRequest(CardDemoInvocationQueries.SimpleCardIntentQuery)
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() )
                .ProcessRequestAsync();

            Assert.AreEqual("Simple Card Title", skill.GetCard().Title.GetText());
        }

        [Test]
        public async Task CardBodyTextCorrect()
        {
            var skill = await new CardDemoSkill(new LoggerFactory())
                .LoadRequest(CardDemoInvocationQueries.SimpleCardIntentQuery)
                .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() )
                .ProcessRequestAsync();

            Assert.AreEqual("I have no image, just this text", skill.GetCard().SimpleCardContent.GetText());
        }


    }
}
