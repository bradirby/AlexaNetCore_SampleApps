﻿using System.Threading.Tasks;
using AlexaNetCore.ZeroToHero.DynamicEntities;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace DynamicEntities.Tests;

public class CancelRequestTests 
{

    [Test]
    public async Task SetsSpokenText()
    {
        var skill = new DynamicEntitySkill(new LoggerFactory());
        skill.LoadRequest(TestData.BuiltInIntentQueries.CancelRequest);
        await skill.ProcessRequestAsync();

        Assert.AreEqual("OK, Cancelling", skill.GetSpokenText());
    }

    [Test]
    public async Task HasNoRepromptText()
    {
        var skill = new DynamicEntitySkill(new LoggerFactory());
        skill.LoadRequest(TestData.BuiltInIntentQueries.CancelRequest);
        await skill.ProcessRequestAsync();
        
        Assert.IsTrue(string.IsNullOrWhiteSpace(skill.GetRepromptText()));
    }

    [Test]
    public async Task ClosesSession()
    {
        var skill = new DynamicEntitySkill(new LoggerFactory());
        skill.LoadRequest(TestData.BuiltInIntentQueries.CancelRequest);
        await skill.ProcessRequestAsync();
        
        Assert.AreEqual(true, skill.ShouldEndSession);
    }


}