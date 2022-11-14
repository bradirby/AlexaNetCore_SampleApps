using AlexaNetCore.RequestModel;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Logging;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AlexaNetCore.ZeroToHero.HelloWorld
{

    // HelloWorld::AlexaNetCore.ZeroToHero.HelloWorld.Function::FunctionHandler

    public class Function
    {
    
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        public async Task<string> FunctionHandler(AlexaRequestEnvelope input)
        {
            var skill = new HelloWorldSkill(new LoggerFactory());
            skill.LoadRequest(input);
            await skill.ProcessRequestAsync();
            return skill.GetResponse();
        }
    }
}
