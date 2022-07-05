﻿using NUnit.Framework;
using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.Util;

namespace AlexaNetCore.ZeroToHero.DynamicEntities.Tests;

public class StopRequestTests 
{

    [Test]
    public async Task SetsSpokenText()
    {
        var skill = new DynamicEntitySkill();
        skill.LoadRequest(BuiltInIntentQueries.StopRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual("Ok, stopping", skill.GetSpokenText());
    }

    [Test]
    public async Task HasNoRepromptText()
    {
        var skill = new DynamicEntitySkill();
        skill.LoadRequest(BuiltInIntentQueries.StopRequest);
        await skill.ProcessRequestAsync();

        Assert.IsTrue(string.IsNullOrWhiteSpace(skill.GetRepromptText()));
    }

    [Test]
    public async Task ClosesSession()
    {
        var skill = new DynamicEntitySkill();
        skill.LoadRequest(BuiltInIntentQueries.StopRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual(true, skill.ShouldEndSession);
    }


}

