using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexaNetCore.Interfaces;
using AlexaNetCore.Model;
using AlexaNetCore.RequestModel;

namespace Internationalization.Tests
{
    public class SetBaseRequestLanguageDebugInterceptor : AlexaBaseRequestInterceptor
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
}
