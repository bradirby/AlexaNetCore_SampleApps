using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.Cards.Tests;

internal class AddStandardCardIntentTest
{

    [Test]
    public async Task CorrectIntentExecuted()
    {
        var skill = await new CardDemoSkill()
            .LoadRequest(CardDemoInvocationQueries.StandardCardIntentQuery)
            .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() , 1000)
            .ProcessRequestAsync();

        Assert.AreEqual(SkillConstants.IntentNames.StandardCardIntentName, skill.ChosenIntent.IntentName);
    }

    [Test]
    public async Task CorrectSpokenTextReturned()
    {
        var skill = await new CardDemoSkill()
            .LoadRequest(CardDemoInvocationQueries.StandardCardIntentQuery)
            .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() , 1000)
            .ProcessRequestAsync();

        Assert.AreEqual("Check your screen for the standard card I added.  There should also be an image.", skill.GetSpokenText());
    }

    [Test]
    public async Task CardExists()
    {
        var skill = await new CardDemoSkill()
            .LoadRequest(CardDemoInvocationQueries.StandardCardIntentQuery)
            .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000)
            .ProcessRequestAsync();

        Assert.IsNotNull(skill.GetCard());
    }

    [Test]
    public async Task CardTitleCorrect()
    {
        var skill = await new CardDemoSkill()
            .LoadRequest(CardDemoInvocationQueries.StandardCardIntentQuery)
            .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000 )
            .ProcessRequestAsync();

        Assert.AreEqual("Standard Card Title", skill.GetCard().Title.GetText());
    }

    [Test]
    public async Task CardBodyTextCorrect()
    {
        var skill = await new CardDemoSkill()
            .LoadRequest(CardDemoInvocationQueries.StandardCardIntentQuery)
            .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor() , 1000)
            .ProcessRequestAsync();

        Assert.AreEqual("There should be in image below", skill.GetCard().StandardCardContent.GetText());
    }

    [Test]
    public async Task LargeImageLinkCorrect()
    {
        var skill = await new CardDemoSkill()
            .LoadRequest(CardDemoInvocationQueries.StandardCardIntentQuery)
            .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000 )
            .ProcessRequestAsync();

        Assert.AreEqual("https://exactmeasurebucket.s3.amazonaws.com/Large.png", skill.GetCard().Image.LargeImageUrl);
    }

    [Test]
    public async Task SmallImageLinkCorrect()
    {
        var skill = await new CardDemoSkill()
            .LoadRequest(CardDemoInvocationQueries.StandardCardIntentQuery)
            .RegisterResponseInterceptor(new ResponseValidationDebugInterceptor(), 1000 )
            .ProcessRequestAsync();

        Assert.AreEqual("https://exactmeasurebucket.s3.amazonaws.com/Small.png", skill.GetCard().Image.SmallImageUrl);
    }

}