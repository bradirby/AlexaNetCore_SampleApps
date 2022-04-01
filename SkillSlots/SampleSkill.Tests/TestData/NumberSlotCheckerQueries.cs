

using System;

namespace SlotChecker.Tests
{
    public class NumberSlotCheckerQueries
    {

        
        public static string sampleMethod()
        {
            var str = @"



";
            return str;

        }

        public static string NegativeFour()
        {
            // give me duration values for two years one months eight days four hours nine minutes and three seconds
            var str = @"


{
	""version"": ""1.0"",
	""session"": {
		""new"": false,
		""sessionId"": ""amzn1.echo-api.session.XXXXXXXXXXXXXXXXXX"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.XXXXXXXXXXXXXXXXXX""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.XXXXXXXXXXXXXXXXXX""
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
				""applicationId"": ""amzn1.ask.skill.XXXXXXXXXXXXXXXXXX""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.XXXXXXXXXXXXXXXXXX""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.XXXXXXXXXXXXXXXXXX"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""XXXXXXXXXXXXXXXXXX""
		}
	},
	""request"": {
		""type"": ""IntentRequest"",
		""requestId"": ""amzn1.echo-api.request.XXXXXXXXXXXXXXXXXX"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-04-01T17:09:20Z"",
		""intent"": {
			""name"": ""NumberSlotCheckerIntent"",
			""confirmationStatus"": ""NONE"",
			""slots"": {
				""__Conjunction"": {
					""name"": ""__Conjunction"",
					""confirmationStatus"": ""NONE""
				},
				""numberInputValue"": {
					""name"": ""numberInputValue"",
					""value"": ""-4"",
					""confirmationStatus"": ""NONE"",
					""source"": ""USER"",
					""slotValue"": {
						""type"": ""Simple"",
						""value"": ""-4""
					}
				}
			}
		}
	}
}



";
            return str;

        }

    }

}
