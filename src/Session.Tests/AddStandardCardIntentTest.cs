using System.Threading.Tasks;
using NUnit.Framework;

namespace Session.Tests;

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