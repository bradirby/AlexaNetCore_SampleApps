namespace AlexaNetCore.ZeroToHero.Interceptors.Tests
{
    public class IterceptorSampleQueries
    {

        public static string IsInterceptorActive=>
            @"

{
	""version"": ""1.0"",
	""session"": {
		""new"": false,
		""sessionId"": ""amzn1.echo-api.session.xxxxxx"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.xxxxxx""
		},
		""attributes"": {
			""username"": ""Jeff Bezos""
		},
		""user"": {
			""userId"": ""amzn1.ask.account.xxxxxx""
		}
	},
	""context"": {
		""Viewports"": [
			{
				""type"": ""APL"",
				""id"": ""main"",
				""shape"": ""RECTANGLE"",
				""dpi"": 213,
				""presentationType"": ""STANDARD"",
				""canRotate"": false,
				""configuration"": {
					""current"": {
						""mode"": ""HUB"",
						""video"": {
							""codecs"": [
								""H_264_42"",
								""H_264_41""
							]
						},
						""size"": {
							""type"": ""DISCRETE"",
							""pixelWidth"": 1280,
							""pixelHeight"": 800
						}
					}
				}
			}
		],
		""Viewport"": {
			""experiences"": [
				{
					""arcMinuteWidth"": 346,
					""arcMinuteHeight"": 216,
					""canRotate"": false,
					""canResize"": false
				}
			],
			""mode"": ""HUB"",
			""shape"": ""RECTANGLE"",
			""pixelWidth"": 1280,
			""pixelHeight"": 800,
			""dpi"": 213,
			""currentPixelWidth"": 1280,
			""currentPixelHeight"": 800,
			""touch"": [
				""SINGLE""
			],
			""video"": {
				""codecs"": [
					""H_264_42"",
					""H_264_41""
				]
			}
		},
		""Extensions"": {
			""available"": {
				""aplext:backstack:10"": {}
			}
		},
		""System"": {
			""application"": {
				""applicationId"": ""amzn1.ask.skill.xxxxxx""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.xxxxxx""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.xxxxxx"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""xxxxxx.xxxxxx.xxxxxx-xxxxxx-xxxxxx-xxxxxx-xxxxxx""
		}
	},
	""request"": {
		""type"": ""IntentRequest"",
		""requestId"": ""amzn1.echo-api.request.xxxxxx"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-05-24T22:26:52Z"",
		""intent"": {
			""name"": ""InterceptorIntentHandler"",
			""confirmationStatus"": ""NONE""
		}
	}
}

";

    }


}
