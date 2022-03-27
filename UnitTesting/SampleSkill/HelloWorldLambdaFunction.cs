using AlexaNetCore;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AlexaNetCoreSampleSkill
{
    public class HelloWorldLambdaFunction
    {
        /// <summary>
        /// This is all that is necessary for a fully functional skill.
        /// We let the AWS processing turn the JSON string into the proper AlexaSkillRequestEnvelop object we want, then process it.
        /// We can inject the ILambdaContext just by including it in the method signature, but for this skill we do not need it
        /// </summary>
        public string HelloWorldLambdaFunctionHandler(AlexaSkillRequestEnvelope input)
        {
            return  new AlexaNetCoreHelloWorldSkill().LoadRequest(input).ProcessRequest().CreateAlexaResponse();
        }

      
     
    }
}
