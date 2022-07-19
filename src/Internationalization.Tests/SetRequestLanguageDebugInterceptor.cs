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
    public class SetRequestLanguageDebugInterceptor : IAlexaRequestInterceptor
    {
        private AlexaLocale NewLocale;

        public SetRequestLanguageDebugInterceptor(AlexaLocale newLocale)
        {
            NewLocale = newLocale;
        }

        public Task<AlexaRequestEnvelope> ProcessAsync(AlexaRequestEnvelope reqEnv)
        {
            reqEnv.Request.LocaleString = NewLocale.LocaleString;
            return Task.FromResult(reqEnv);
        }

    }
}
