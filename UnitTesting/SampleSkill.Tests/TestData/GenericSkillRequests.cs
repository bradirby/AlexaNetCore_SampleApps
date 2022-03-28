namespace UnitTestingSkill.Tests
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
		""sessionId"": ""amzn1.echo-api.session.ac1f7d2e-c387-4101-a671-0c4e90cca2be"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.5d4eca0f-6700-465e-9a59-375cb713f10e""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.AFS66GQ7L5RWCMWP3OL6722IS57N6QXW4AXJURZYAA6TCK7DJDRPDIPPKDNGIWQBHNPCC5RAAYE56LZOFOAB45SWGPTRNG32KCAMRN2UHBYBKQF43ZZNYUUHLYC2Q3ES3IS36IOD3FJFUKSO6NV6GMLN2PPZ2TV7V7XBYKUYI44D5VM6DOCOJDN55QANVI4SDCN3QYWR7LOCECI""
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
				""applicationId"": ""amzn1.ask.skill.5d4eca0f-6700-465e-9a59-375cb713f10e""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.AFS66GQ7L5RWCMWP3OL6722IS57N6QXW4AXJURZYAA6TCK7DJDRPDIPPKDNGIWQBHNPCC5RAAYE56LZOFOAB45SWGPTRNG32KCAMRN2UHBYBKQF43ZZNYUUHLYC2Q3ES3IS36IOD3FJFUKSO6NV6GMLN2PPZ2TV7V7XBYKUYI44D5VM6DOCOJDN55QANVI4SDCN3QYWR7LOCECI""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.AFWOBHH4AOT3SZE2G7DGHMVPP54Z36KJOVAPLGSWQEZT2EHYJIDWINVG2ZBNL6UUG2CISII4AIVJ3A5L3AXK2U42VVPHOJTMALR4MDPV5GEWRQQ2ZXY5SKZLDY3RGPJHQ4BQY52IW5YFZHOQWMIAXXSBMIWQ"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjVkNGVjYTBmLTY3MDAtNDY1ZS05YTU5LTM3NWNiNzEzZjEwZSIsImV4cCI6MTY0ODQ3MDIwMiwiaWF0IjoxNjQ4NDY5OTAyLCJuYmYiOjE2NDg0Njk5MDIsInByaXZhdGVDbGFpbXMiOnsiY29udGV4dCI6IkFBQUFBQUFBQUFEeHdzOXpDQVV6OTczS2s0MS9HWVd3SkFFQUFBQUFBQUFwVnZsUitOVzRsQ0w0WWJZZFpOdHhwZjVHeDVsWHFPcFJWcnhvRDlNSkpRM042UlV3UVJzUGhnYlFTUXhMZGdXNUV5MUV4NE5GbDV6TW9WSlRLNTFkOFYvWTcrWWdWbVI3cWw2SXhUdFdEQnRXZ0Vhc2NXUzhjQ3pHSjVhUGlmclJSNXloNGZsdFh0NVdnaFQwQXhLcXFNdkNWd3JySS8xUmZPYU8xNFVIQWwwMld4SFREcUhyMWpPbG5mWXZYTkFkWHFzUk0zeWpGbFdPbFJsVXdaMnh6MTlCb2JEY0VUaGZDbnZYekRZLzdrUDhiUlNrM3hSVm9PS1E5TXpQSkplcjJ2a25SMitNR3V0aGpWWEhkZXFjRzVzdHo5ZmdsOHlzc29VdnovOWE5NitxVmZlcHRlNWpmRURnd0thakoxWndQNUlHNWc3c2xiYjIwZGJFNEtZS1l6eDU4TmVVVG1ybVhJRi9JZFo2QStkOXN1K1hRNHRsNXByM3RlUUJDRUZ6ZTA3NyIsImNvbnNlbnRUb2tlbiI6bnVsbCwiZGV2aWNlSWQiOiJhbXpuMS5hc2suZGV2aWNlLkFGV09CSEg0QU9UM1NaRTJHN0RHSE1WUFA1NFozNktKT1ZBUExHU1dRRVpUMkVIWUpJRFdJTlZHMlpCTkw2VVVHMkNJU0lJNEFJVkozQTVMM0FYSzJVNDJWVlBIT0pUTUFMUjRNRFBWNUdFV1JRUTJaWFk1U0taTERZM1JHUEpIUTRCUVk1MklXNVlGWkhPUVdNSUFYWFNCTUlXUSIsInVzZXJJZCI6ImFtem4xLmFzay5hY2NvdW50LkFGUzY2R1E3TDVSV0NNV1AzT0w2NzIySVM1N042UVhXNEFYSlVSWllBQTZUQ0s3REpEUlBESVBQS0ROR0lXUUJITlBDQzVSQUFZRTU2TFpPRk9BQjQ1U1dHUFRSTkczMktDQU1STjJVSEJZQktRRjQzWlpOWVVVSExZQzJRM0VTM0lTMzZJT0QzRkpGVUtTTzZOVjZHTUxOMlBQWjJUVjdWN1hCWUtVWUk0NEQ1Vk02RE9DT0pETjU1UUFOVkk0U0RDTjNRWVdSN0xPQ0VDSSJ9fQ.KEHrJRFs8wqQ4oB4NF2tx_3C5t1iMuGRScWo4fNVKw1mPFYkrPMsgy7ZQG-YxhPt4DpV_CLvF40nkfvdbBozsZT44q6NQEm0lmkqc8jAQHNwYXjeM7mDQS9WV8q_3gu1qB-7suVEuNrenmjqwXIlA27oBgcgpbKj5SREmKY_lHb301PUdqsd5n_jIvDplas9crJortYWhpPaVaTNPo87H_9diTsDMUzNtrs9r4Yi9GkvmbzyxdNYWL-MB0mAub_qGbgiGu1QPot5m0CY4rl2_Bojgz7Vt7AqFju2ewMaBcd8OCK8wIZWwvfol_PlF0STcBKKwmI0lII2XQ4io6S7IA""
		}
	},
	""request"": {
		""type"": ""LaunchRequest"",
		""requestId"": ""amzn1.echo-api.request.4dd5a615-a781-4b4c-8402-a8be031199a1"",
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
    ""sessionId"": ""SessionId.3f1f8f0d-3c68-41f0-b24e-25c0bd1743da"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.AFP3ZWPOS2BGJR7OWJZ3DHPKMOMDS7SN3HP3B3GZPDYUVPQUNF65UGMED2LUXUORM5C7PK7RGCTLWN53FR33NJH5OZM4AOYOSJQ64N7QCSWJDZKVFZDWRJKXBDJVWY4TWTLIULKKGJMUEMJSLMBGKMYITAKTCLGRAATLR6KRSGACRCRANGSLPNVLMZC5WJVZXIB4A3EBYBXA5RI""
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
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.AFP3ZWPOS2BGJR7OWJZ3DHPKMOMDS7SN3HP3B3GZPDYUVPQUNF65UGMED2LUXUORM5C7PK7RGCTLWN53FR33NJH5OZM4AOYOSJQ64N7QCSWJDZKVFZDWRJKXBDJVWY4TWTLIULKKGJMUEMJSLMBGKMYITAKTCLGRAATLR6KRSGACRCRANGSLPNVLMZC5WJVZXIB4A3EBYBXA5RI""
    },
    ""new"": false
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.36edaa25-e3ca-4b36-ace0-d647cbbacf55"",
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
    ""sessionId"": ""SessionId.1412af2e-a9aa-453f-9c21-1bda18563169"",
    ""application"": {
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.AFP3ZWPOS2BGJR7OWJZ3DHPKMOMDS7SN3HP3B3GZPDYUVPQUNF65UGMED2LUXUORM5C7PK7RGCTLWN53FR33NJH5OZM4AOYOSJQ64N7QCSWJDZKVFZDWRJKXBDJVWY4TWTLIULKKGJMUEMJSLMBGKMYITAKTCLGRAATLR6KRSGACRCRANGSLPNVLMZC5WJVZXIB4A3EBYBXA5RI""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""InvalidIntent"",
    ""requestId"": ""EdwRequestId.abf39ef4-1c40-49df-9364-a7cf50cfd62a"",
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
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.AFP3ZWPOS2BGJR7OWJZ3DHPKMOMDS7SN3HP3B3GZPDYUVPQUNF65UGMED2LUXUORM5C7PK7RGCTLWN53FR33NJH5OZM4AOYOSJQ64N7QCSWJDZKVFZDWRJKXBDJVWY4TWTLIULKKGJMUEMJSLMBGKMYITAKTCLGRAATLR6KRSGACRCRANGSLPNVLMZC5WJVZXIB4A3EBYBXA5RI""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.abf39ef4-1c40-49df-9364-a7cf50cfd62a"",
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
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.AFP3ZWPOS2BGJR7OWJZ3DHPKMOMDS7SN3HP3B3GZPDYUVPQUNF65UGMED2LUXUORM5C7PK7RGCTLWN53FR33NJH5OZM4AOYOSJQ64N7QCSWJDZKVFZDWRJKXBDJVWY4TWTLIULKKGJMUEMJSLMBGKMYITAKTCLGRAATLR6KRSGACRCRANGSLPNVLMZC5WJVZXIB4A3EBYBXA5RI""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.19bdfa12-843e-4016-af94-055bf1d5c7c0"",
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
		""sessionId"": ""amzn1.echo-api.session.ce498e3f-9494-4b28-b029-de6577092411"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.6acd2461-06d1-44f0-ad5c-c9a16bdb8830""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.AGTRXT3Y3FU74LNNIASLVD6C37PZAI4IKC2FYEB3CMUM7MRUWAGVLYQQWFIGXC5LGG33ENHGY726D3TIGU25WJZTFZI6R7A52ZHPOVF6XVFGY6EWX2UNLVFXEISZFKK3AT3CKHQQZXCQC3FDNMZSDLKT7YNXHO3H5AFFX22NBENRASTIZLHZ3RLVITQXIFPLHSZZDBLV5NJABZI""
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
				""applicationId"": ""amzn1.ask.skill.6acd2461-06d1-44f0-ad5c-c9a16bdb8830""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.AGTRXT3Y3FU74LNNIASLVD6C37PZAI4IKC2FYEB3CMUM7MRUWAGVLYQQWFIGXC5LGG33ENHGY726D3TIGU25WJZTFZI6R7A52ZHPOVF6XVFGY6EWX2UNLVFXEISZFKK3AT3CKHQQZXCQC3FDNMZSDLKT7YNXHO3H5AFFX22NBENRASTIZLHZ3RLVITQXIFPLHSZZDBLV5NJABZI""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.AEC6MAIKKWRL7EYPPCCDRKW6F6SALTUIEMLC7URKBCHYJM5BAU7IVZUUNCCY5NVHIBDS6PM2NGDQ42U66RSZE7GOC732VOZCSQWC5APXAMAPBI45N4OSF3XKSF6WERDNHF5HACPRBVHRICXTAQ2E25VAT7ZA"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjZhY2QyNDYxLTA2ZDEtNDRmMC1hZDVjLWM5YTE2YmRiODgzMCIsImV4cCI6MTYzMjQ4MTA1MSwiaWF0IjoxNjMyNDgwNzUxLCJuYmYiOjE2MzI0ODA3NTEsInByaXZhdGVDbGFpbXMiOnsiY29udGV4dCI6IkFBQUFBQUFBQUFDakhmbHlMcHdmUS8yalBNNUVKOUc0SkFFQUFBQUFBQUFaQUw0emlOQkxlWjRPSEhmSlloZmJOajdPYTJaN3lvMjFrWE5DN090a2hzQkFTLzFWMzh2MlVwWnF2L2NDcUlNZEE3MVZCVnJsSjlRR3h2L2M1UnJ5MDV3dURjV2hldTdaR2xmeHR5czdMZ0paVnM5dVBQVjd5TzViSXVzL0tVbkkxNWYxVU9lYnF3S2Y1Z0tJODhzOEM5NXVHZkVGSEVsdHVGT0FSQnZ3eW1NNzMrUGxkbFREVFNBN0IzQ2lTV0xHWFVsSVYwdEs4U0NSVk1LTHNrdFk4dExkQzRqNVdzZ3NDWlpDNEhyNzc4bVRtT1dGRk9IcE5TQ2k4Zng3YU9WNUdIWmdlclJJZEFNb1J2cGF2RElPczY2N3ZVU2s2eW52ZStNMnJsNGtISzNXU21ROFJobGdXK2VUdWZJblZIM1RyVlBIMmpaZ0piTEZvaml1MG42dTlkSVRqeDhYZVFON2NMT1g5eFordHU2cEZEcm5XNmErcG4zNXpZc2F3VzNEME9JRiIsImNvbnNlbnRUb2tlbiI6bnVsbCwiZGV2aWNlSWQiOiJhbXpuMS5hc2suZGV2aWNlLkFFQzZNQUlLS1dSTDdFWVBQQ0NEUktXNkY2U0FMVFVJRU1MQzdVUktCQ0hZSk01QkFVN0lWWlVVTkNDWTVOVkhJQkRTNlBNMk5HRFE0MlU2NlJTWkU3R09DNzMyVk9aQ1NRV0M1QVBYQU1BUEJJNDVONE9TRjNYS1NGNldFUkROSEY1SEFDUFJCVkhSSUNYVEFRMkUyNVZBVDdaQSIsInVzZXJJZCI6ImFtem4xLmFzay5hY2NvdW50LkFHVFJYVDNZM0ZVNzRMTk5JQVNMVkQ2QzM3UFpBSTRJS0MyRllFQjNDTVVNN01SVVdBR1ZMWVFRV0ZJR1hDNUxHRzMzRU5IR1k3MjZEM1RJR1UyNVdKWlRGWkk2UjdBNTJaSFBPVkY2WFZGR1k2RVdYMlVOTFZGWEVJU1pGS0szQVQzQ0tIUVFaWENRQzNGRE5NWlNETEtUN1lOWEhPM0g1QUZGWDIyTkJFTlJBU1RJWkxIWjNSTFZJVFFYSUZQTEhTWlpEQkxWNU5KQUJaSSJ9fQ.Fr1rM2r_98V4GhYRsaX36G9iPIHiQ9wRXO_aMbS7VdqPwNicNJsmYEo0aL4mZXLusj95r95slI7OiRxyhSwFEDFZIX_9geHFnBts7zlN0j866W62CSjFt5593CkfAg36G3DLdORUnoSPSTrHBjC_tsOH2t4XeDkRJBDDqU65sMGGqbc8ivhRpzFMW4MZej7bFf54i3VvrkaF87d2OZGHEjVkMC0YCXHHSwA9ZcoA9zPIBpWtqtcZVC4Qh61sfJxg8d8vnTGoeM5R7ZE-JZsYC7DNgwE3HQ-48mMcTMwLlWlnkHEodku07YgtPENQIyiRqxNSdGETk1vQIjn2vMbVIw""
		}
	},
	""request"": {
		""type"": ""LaunchRequest"",
		""requestId"": ""amzn1.echo-api.request.feb4406d-01c0-4d3e-aa6f-1da6ebd717f8"",
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
                ""applicationId"": ""amzn1.ask.skill.11111111-1111-1111-1111-111111111111""
    },
    ""attributes"": { },
    ""user"": {
                ""userId"": ""amzn1.ask.account.AFP3ZWPOS2BGJR7OWJZ3DHPKMOMDS7SN3HP3B3GZPDYUVPQUNF65UGMED2LUXUORM5C7PK7RGCTLWN53FR33NJH5OZM4AOYOSJQ64N7QCSWJDZKVFZDWRJKXBDJVWY4TWTLIULKKGJMUEMJSLMBGKMYITAKTCLGRAATLR6KRSGACRCRANGSLPNVLMZC5WJVZXIB4A3EBYBXA5RI""
    },
    ""new"": true
  },
  ""request"": {
    ""type"": ""IntentRequest"",
    ""requestId"": ""EdwRequestId.e9dd3904-6215-430d-8063-595279c04455"",
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
    ""sessionId"": ""amzn1.echo-api.session.123456789012"",
    ""application"": {
      ""applicationId"": ""amzn1.ask.skill.111111111""
    },
    ""attributes"": {},
    ""user"": {
      ""userId"": ""amzn1.ask.account.testUser""
    }
  },
  ""context"": {
    ""System"": {
      ""application"": {
        ""applicationId"": ""amzn1.ask.skill.111111111""
      },
      ""user"": {
        ""userId"": ""amzn1.ask.account.testUser""
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
    ""requestId"": ""amzn1.echo-api.request.1234"",
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
