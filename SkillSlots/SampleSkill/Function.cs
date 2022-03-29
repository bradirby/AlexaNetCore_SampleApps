using AlexaNetCore;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SkillSlots
{
    public class Function
    {
        public string FunctionHandler(AlexaSkillRequestEnvelope input)
        {
            return new BirthdayEchoSkill().LoadRequest(input).ProcessRequest().CreateAlexaResponse();
        }
    }
}
