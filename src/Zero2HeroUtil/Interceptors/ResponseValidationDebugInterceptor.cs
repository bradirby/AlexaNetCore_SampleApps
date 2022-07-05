using AlexaNetCore.Model;
using AlexaNetCore.RequestModel;
using System.ComponentModel.DataAnnotations;
using AlexaNetCore.Interfaces;

namespace AlexaNetCore.ZeroToHero.Util
{
    public class ResponseValidationDebugInterceptor : IAlexaResponseInterceptor
    {


        /// <summary>
        /// This interceptor validates the response and throws an exception if any are found.
        /// This is meant for use in Debug and unit tests
        /// </summary>
        public Task<AlexaResponseEnvelope> ProcessAsync(AlexaRequestEnvelope reqEnv, AlexaResponseEnvelope respEnv)
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
            if (errLst.Count > 0) throw new ValidationException( $"Found {errLst.Count} errors.  The first is: {errLst.First()}");

            return Task.FromResult(respEnv);
        }

    }
}
