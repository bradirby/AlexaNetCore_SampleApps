using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session.Tests.TestData
{
	public class BuiltInIntentQueries
	{

		public static string LaunchRequest =>
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
		""type"": ""LaunchRequest"",
		""requestId"": ""amzn1.echo-api.request.xxxxxx"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-03-28T12:18:23Z"",
		""shouldLinkResultBeReturned"": false
	}
}

"
				;


		public static string GetUserState =>
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
		""type"": ""LaunchRequest"",
		""requestId"": ""amzn1.echo-api.request.xxxxxx"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-03-28T12:18:23Z"",
		""shouldLinkResultBeReturned"": false
	}
}

"
				;




		public static string CancelRequest =>
			@"
{
  ""session"": {
    ""sessionId"": ""SessionId.xxxxxx"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.xxxxxx""
    },
    ""new"": false
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.xxxxxx"",
    ""locale"": ""en-US"",
    ""timestamp"": ""2016-08-30T03:08:13Z"",
    ""intent"": {
      ""name"": ""AMAZON.CancelIntent"",
      ""slots"": {}
    }
  },
  ""version"": ""1.0""
}

";






		public static string HelpRequest =>
			@"
{
  ""session"": {
    ""sessionId"": ""SessionId.xxxxxx"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.xxxxxx""
    },
    ""new"": false
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.xxxxxx"",
    ""locale"": ""en-US"",
    ""timestamp"": ""2016-08-30T03:08:13Z"",
    ""intent"": {
      ""name"": ""AMAZON.HelpIntent"",
      ""slots"": {}
    }
  },
  ""version"": ""1.0""
}

";





		/// <summary>
		/// The intent type for this intent will not be reconized by the skill engine
		/// </summary>
		public static string InvalidIntentType =>
			@"
{
  ""session"": {
    ""sessionId"": ""SessionId.xxxxxx"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.xxxxxx""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""InvalidIntent"",
    ""requestId"": ""EdwRequestId.xxxxxx"",
    ""locale"": ""en-US"",
    ""timestamp"": ""2016-08-18T20:22:53Z"",
    ""intent"": {
      ""name"": ""WithoutDecimal"",
      ""slots"": {
        ""sourceType"": {
          ""name"": ""sourceType"",
          ""value"": ""meter""
        },
        ""inputValue"": {
          ""name"": ""inputValue"",
          ""value"": ""1""
        },
        ""destType"": {
          ""name"": ""destType"",
          ""value"": ""yards""
        }
      }
    }
  },
  ""version"": ""1.0""
}
"
				;





		/// <summary>
		/// The
		/// </summary>
		public static string GetRequestWithIntentName(string intentName)
		{

			return @"

{
	""version"": ""1.0"",
	""session"": {
		""new"": true,
		""sessionId"": ""amzn1.echo-api.session.77e4ba46-xxxxxxxx"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.7de6fb3a-xxxxxxxx""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.xxxxxxxx""
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
				""applicationId"": ""amzn1.ask.skill.xxxxxxxx""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.xxxxxxxx""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.xxxxxxxx"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""xxxxxxxx.xxxxxxxx.xxxxxxxx-xxxxxxxx-xxxxxxxx-xxxxxxxx-xxxxxxxx-xxxxxxxx""
		}
	},
	""request"": {
		""type"": ""IntentRequest"",
		""requestId"": ""amzn1.echo-api.request.xxxxxxxx"",
		""locale"": ""en-US"",
		""timestamp"": ""2021-09-28T13:46:55Z"",
		""intent"": {
			""name"": ""!!FindAndReplaceThisIntent!!"",
			""confirmationStatus"": ""NONE"",
			""slots"": {
				""requestedDate"": {
					""name"": ""requestedDate"",
					""value"": ""2021-09-29"",
					""confirmationStatus"": ""NONE"",
					""source"": ""USER"",
					""slotValue"": {
						""type"": ""Simple"",
						""value"": ""2021-09-29""
					}
				}
			}
		}
	}
}

".Replace("!!FindAndReplaceThisIntent!!", intentName);

		}

		public static string EmptyRequest =>
			@"
{
  ""session"": {
    ""sessionId"": ""SessionId.xxxxxx"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.xxxxxx""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.xxxxxx"",
    ""locale"": ""en-US"",
    ""timestamp"": ""2016-08-30T02:52:55Z"",
    ""intent"": {
      ""name"": ""WithoutDecimal"",
      ""slots"": {
        ""sourceType"": {
          ""name"": ""sourceType""
        },
        ""inputValue"": {
          ""name"": ""inputValue""
        },
        ""destType"": {
          ""name"": ""destType""
        }
      }
    }
  },
  ""version"": ""1.0""
}

";






		public static string StopRequest =>
			@"
{
  ""session"": {
    ""sessionId"": ""SessionId.bbb7ba23-xxxxxx"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.xxxxxx""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.xxxxxx"",
    ""locale"": ""en-US"",
    ""timestamp"": ""2016-08-30T18:41:50Z"",
    ""intent"": {
      ""name"": ""AMAZON.StopIntent"",
      ""slots"": {}
    }
  },
  ""version"": ""1.0""
}

";




	}


}
