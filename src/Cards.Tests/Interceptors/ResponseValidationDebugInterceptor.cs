﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexaNetCore.Interfaces;
using AlexaNetCore.Model;
using AlexaNetCore.RequestModel;

namespace Cards.Tests.Interceptors
{
    public class ResponseValidationDebugInterceptor : AlexaBaseResponseInterceptor
    {


        /// <summary>
        /// This interceptor validates the response and throws an exception if any are found.
        /// This is meant for use in LogDebug and unit tests
        /// </summary>
        public override Task ProcessAsync(IAlexaRequestEnvelope reqEnv, IAlexaResponseEnvelope respEnv)
        {
            //https://developer.amazon.com/en-US/docs/alexa/custom-skills/request-and-response-json-reference.html
            //When using the <audio> SSML tag:
            //  The combined total time for all audio files in the outputSpeech property of the response can't be more than 240 seconds.
            //  The combined total time for all audio files in the reprompt property of the response can't be more than 90 seconds.
            //  The token included in an audioItem.stream for the AudioPlayer.Play directive can't exceed 1024 characters.
            //  The url included in an audioItem.stream for the AudioPlayer.Play directive can't exceed 8000 characters.
            //  The payload of a CustomInterfaceController.SendDirective directive can't exceed 1000 bytes. For details about this directive, see Respond to Alexa with a directive targeted to a gadget.
            //The total size of your response can't exceed 120 kilobytes.

            var errLst = respEnv.Validate();
            if (errLst.Count > 0) throw new ValidationException($"Found {errLst.Count} errors.  The first is: {errLst.First()}");

            return Task.CompletedTask;
        }

    }
}