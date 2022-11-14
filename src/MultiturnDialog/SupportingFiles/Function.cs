using AlexaNetCore.RequestModel;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Logging;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AlexaNetCore.ZeroToHero.MultiturnDialog
{

    public class Function
    {
    
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        public async Task<string> FunctionHandler(AlexaRequestEnvelope input)
        {
            return (await new MultiturnDialogSkill(new LoggerFactory())
                .LoadRequest(input)
                .ProcessRequestAsync())
                .GetResponse();
        }
    }
}
