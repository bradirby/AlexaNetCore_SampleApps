﻿using AlexaNetCore.Interfaces;
using AlexaNetCore.Model;
using AlexaNetCore.RequestModel;

namespace AlexaNetCore.ZeroToHero.Util;


/// <summary>
/// This interceptor will change the language of the incoming request to
/// the value given in order to simulate requests from different locales
/// </summary>
public class SetBaseRequestLanguageDebugInterceptor: AlexaBaseRequestInterceptor
{
    private AlexaLocale NewLocale;

    public SetBaseRequestLanguageDebugInterceptor(AlexaLocale newLocale)
    {
        NewLocale = newLocale;
    }

    public override Task ProcessAsync(IAlexaRequestEnvelope reqEnv)
    {
        reqEnv.Request.LocaleString = NewLocale.LocaleString;
        return Task.CompletedTask;
    }

}