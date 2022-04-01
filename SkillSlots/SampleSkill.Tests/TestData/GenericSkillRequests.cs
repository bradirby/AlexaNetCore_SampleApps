namespace SkillSlots.Tests
{

    /// <summary>
    /// Class that holds all the JSON you want to test with.  This can be copy/pasted out of the Alexa test console
    /// </summary>
    public class GenericSkillRequests 
    {
        
        public static string LaunchRequest()
        {
            var str = @"


{
	""version"": ""1.0"",
	""session"": {
		""new"": true,
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
		""type"": ""LaunchRequest"",
		""requestId"": ""amzn1.echo-api.request.XXXXXXXXXXXXXXXXXX"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-03-28T12:18:23Z"",
		""shouldLinkResultBeReturned"": false
	}
}

"
                ;
            return str;
        }


        public static string StartSession()
        {
            var str = @"
{
  ""session"": {
    ""new"": true,
    ""sessionId"": ""session1234"",
    ""attributes"": { },
    ""user"": {
                ""userId"": null
    },
    ""application"": {
                ""applicationId"": ""amzn1.echo-sdk-ams.app.[unique-value-here]""
    }
        },
  ""version"": ""1.0"",
  ""request"": {
    ""type"": ""LaunchRequest"",
    ""requestId"": ""request5678""
  }
}


";

            return str;

        }


        public static string CancelRequest()
        {
            var str = @"
{
  ""session"": {
    ""sessionId"": ""SessionId.XXXXXXXXXXXXXXXXXX"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.XXXXXXXXXXXXXXXXXX""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.XXXXXXXXXXXXXXXXXX""
    },
    ""new"": false
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.36edaa25-e3ca-4b36-ace0-d647cbbacf55"",
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

            return str;

        }


        public static string HelpRequest()
        {
            var str = @"
{
  ""session"": {
    ""sessionId"": ""SessionId.3f1f8f0d-3c68-41f0-b24e-25c0bd1743da"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.XXXXXXXXXXXXXXXXXX""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.XXXXXXXXXXXXXXXXXX""
    },
    ""new"": false
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.XXXXXXXXXXXXXXXXXX"",
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

            return str;

        }

        
        public static string InvalidIntentType()
        {
            var str = @"
{
  ""session"": {
    ""sessionId"": ""SessionId.XXXXXXXXXXXXXXXXXX"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.XXXXXXXXXXXXXXXXXX""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.XXXXXXXXXXXXXXXXXX""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""InvalidIntent"",
    ""requestId"": ""EdwRequestId.XXXXXXXXXXXXXXXXXX"",
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
            return str;
        }


        public static string InvalidIntentName()
        {
            var str = @"
{
  ""session"": {
    ""sessionId"": ""SessionId.1412af2e-a9aa-453f-9c21-1bda18563169"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.XXXXXXXXXXXXXXXXXX""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.XXXXXXXXXXXXXXXXXX""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.XXXXXXXXXXXXXXXXXX"",
    ""locale"": ""en-US"",
    ""timestamp"": ""2016-08-18T20:22:53Z"",
    ""intent"": {
      ""name"": ""InvalidIntentName"",
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

            return str;
        }

        
        public static string EmptyRequest()
        {
            var str = @"
{
  ""session"": {
    ""sessionId"": ""SessionId.a8b29a9e-b5cf-4d7e-89f0-6fdf1cdd1c9c"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.XXXXXXXXXXXXXXXXXX""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.XXXXXXXXXXXXXXXXXX""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.XXXXXXXXXXXXXXXXXX"",
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
            return str;

        }

    
        public static string LaunchRequestOld()
        {
            var str = @"

{
	""version"": ""1.0"",
	""session"": {
		""new"": true,
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
		""type"": ""LaunchRequest"",
		""requestId"": ""amzn1.echo-api.request.XXXXXXXXXXXXXXXXXX"",
		""locale"": ""en-US"",
		""timestamp"": ""2021-09-24T10:52:31Z"",
		""shouldLinkResultBeReturned"": false
	}
}

";

            return str;

        }
        

        public static string StopRequest()
        {
            var str = @"
{
  ""session"": {
    ""sessionId"": ""SessionId.bbb7ba23-daef-4699-9755-454b3e601cae"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.XXXXXXXXXXXXXXXXXX""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.XXXXXXXXXXXXXXXXXX""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.XXXXXXXXXXXXXXXXXX"",
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

            return str;

        }

        public static string EndSession()
        {
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
      ""userId"": ""amzn1.ask.account.testUser""
    }
  },
  ""context"": {
    ""System"": {
      ""application"": {
        ""applicationId"": ""amzn1.ask.skill.XXXXXXXXXXXXXXXXXX""
      },
      ""user"": {
        ""userId"": ""amzn1.ask.account.XXXXXXXXXXXXXXXXXX""
      },
      ""device"": {
        ""supportedInterfaces"": {
          ""AudioPlayer"": {}
        }
      }
    }
  },
  ""request"": {
    ""type"": ""SessionEndedRequest"",
    ""requestId"": ""amzn1.echo-api.request.XXXXXXXXXXXXXXXXXX"",
    ""timestamp"": ""2016-10-27T21:11:41Z"",
    ""locale"": ""en-US"",
    ""reason"": ""USER_INITIATED""
  }
}


";
            return str;

        }



    }


}
