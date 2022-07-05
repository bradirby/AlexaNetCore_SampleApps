using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaNetCore.ZeroToHero.Cards.Tests
{
    public static class CardDemoInvocationQueries
    {

        public static string SimpleCardIntentQuery =>
            @"


{
	""version"": ""1.0"",
	""session"": {
		""new"": true,
		""sessionId"": ""amzn1.echo-api.session.ac1f7d2e-c387-4101-a671-0c4e90cca2be"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.xxxxxx""
		},
		""attributes"": {},
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
			""apiAccessToken"": ""xxxxxx""
		}
	},
	  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.da47dcf7-4c54-4927-a798-0a67f8e8bca7"",
    ""locale"": ""en-US"",
    ""timestamp"": ""2016-08-19T15:35:04Z"",
    ""intent"": {
      ""name"": ""SimpleCardIntent""
    }
  }
}

";




		        public static string StandardCardIntentQuery =>
            @"


{
	""version"": ""1.0"",
	""session"": {
		""new"": true,
		""sessionId"": ""amzn1.echo-api.session.ac1f7d2e-c387-4101-a671-0c4e90cca2be"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.xxxxxx""
		},
		""attributes"": {},
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
			""apiAccessToken"": ""xxxxxx""
		}
	},
	  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.da47dcf7-4c54-4927-a798-0a67f8e8bca7"",
    ""locale"": ""en-US"",
    ""timestamp"": ""2016-08-19T15:35:04Z"",
    ""intent"": {
      ""name"": ""StandardCardIntent""
    }
  }
}

";



    }




}
