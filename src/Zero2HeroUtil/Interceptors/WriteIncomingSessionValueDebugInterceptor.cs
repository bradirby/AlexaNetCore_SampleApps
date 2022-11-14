using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexaNetCore;
using AlexaNetCore.Interfaces;
using AlexaNetCore.RequestModel;

namespace Zero2HeroUtil.Interceptors
{
    public class WriteIncomingSessionValueDebugInterceptor : AlexaBaseRequestInterceptor
    {
        private string SessionKey;
        private string SessionValue;

        public WriteIncomingSessionValueDebugInterceptor(string key, string value)
        {
            SessionKey = key;
            SessionValue = value;
        }


        public override Task<IAlexaRequestEnvelope> ProcessAsync(IAlexaRequestEnvelope reqEnv)
        {
            SetSessionValue(SessionKey, SessionValue);
            return Task.FromResult(reqEnv);
        }
    }
}
