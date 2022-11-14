using System;
using AlexaNetCore.Interfaces;
using AlexaNetCore.Model;
using AlexaNetCore.RequestModel;

namespace AlexaNetCore.ZeroToHero.Util
{

    /// <summary>
    /// This interceptor will add a reprompt to any appropriate response that does not already have one.
    /// Intents that have the ShouldendSession set to true will not get a reprompt.  All others
    /// will.
    /// </summary>
    public class SetRepromptInterceptor : AlexaBaseResponseInterceptor
    {

        private AlexaMultiLanguageText GenericReprompt { get; set; }


        public SetRepromptInterceptor(AlexaMultiLanguageText txt)
        {
            GenericReprompt = txt;
        }

        public SetRepromptInterceptor(string txt)
        {
            GenericReprompt = new AlexaMultiLanguageText(txt);
        }

        /// <summary>
        /// Sample response interceptor that automatically adds a reprompt
        /// to requests if there is not one already.  It only adds if the intent
        /// want's to keep the session open
        /// </summary>
        public override Task ProcessAsync( IAlexaRequestEnvelope reqEnv, IAlexaResponseEnvelope respEnv)
        {
            try
            {
                if (respEnv.IsRepromptSet) return Task.FromResult(respEnv);
                if (respEnv.ShouldEndSession.HasValue && !respEnv.ShouldEndSession.Value)
                    respEnv.Reprompt(GenericReprompt);
                return Task.CompletedTask;
            }
            catch (Exception)
            {
                //ignore
                return Task.CompletedTask;
            }
        }

    }
}