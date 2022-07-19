using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.Interceptors.Tests;

public class SetRepromptInterceptorTests
{
    [Test]
    public async Task SetRepromptInterceptor_LaunchRequest_DoesNotOverwriteExistingReprompt()
    {
        var skill = await new InterceptorSkill()
            .LoadRequest(InterceptorSampleQueries.LaunchRequest)
            .ProcessRequestAsync();
        Assert.AreEqual("The interceptors are running, are you still there?", skill.GetRepromptText());
    }


    [Test]
    public async Task SetRepromptInterceptor_CancelRequest_DoesNotAddReprompt()
    {
        var skill = await new InterceptorSkill()
            .LoadRequest(InterceptorSampleQueries.CancelIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("", skill.GetRepromptText());
    }

    [Test]
    public async Task SetRepromptInterceptor_HelpRequest_AddsGenericReprompt()
    {
        var skill = await new InterceptorSkill()
            .LoadRequest(InterceptorSampleQueries.HelpIntent)
            .ProcessRequestAsync();
        Assert.AreEqual("This is the injected reprompt.", skill.GetRepromptText());
    }





}

