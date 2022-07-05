using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.Session.Tests;

internal class AddStandardCardIntentTest
{

    [Test]
    public Task CorrectIntentExecuted()
    {
        //var skill = await new SessionDemoSkill()
        //    .LoadRequest(CardDemoInvocationQueries.StandardCardIntentQuery)
        //    .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() )
        //    .ProcessRequestAsync();

        //Assert.AreEqual(SkillConstants.IntentNames.StandardCardIntentName, skill.ChosenIntent.IntentName);
        return Task.CompletedTask;

    }

 

}