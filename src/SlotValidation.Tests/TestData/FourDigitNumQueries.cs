using System.Net.NetworkInformation;

namespace SlotValidation.Tests.TestData;

public class FourDigitNumQueries
{

    public static string SingleYear_NoValidation_Required => @"


{
	""version"": ""1.0"",
	""session"": {
		""new"": false,
		""sessionId"": ""amzn1.echo-api.session.f5c0d6da-d243-47ca-8b90-90b00a0a1104"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
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
				""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.AFPNO3ZF25Y4VK2N6RDWNWR2G6ID5MN7U7W47WL3IBEKLLEUVKCCCERVUGR6UVBPZAV4XGKY2CW3B75EXP2YZNGIZ3GIBSBMXQGNUYOC3PSVGISFNNYUN2UCZKJOG2DI2K544APEUBYQBWPSJ5JJ2IZZQ4FQ"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjcwMjM1Y2U3LTEzYmUtNDJkOS1iNjQ1LTI2YzNhYjIzNDM4MSIsImV4cCI6MTY1OTY5NDc0NiwiaWF0IjoxNjU5Njk0NDQ2LCJuYmYiOjE2NTk2OTQ0NDYsInByaXZhdGVDbGFpbXMiOnsiY29udGV4dCI6IkFBQUFBQUFBQUFEQ1didlRsdmVKN3FaL3U5dmtMZ2pTSkFFQUFBQUFBQURCeEJOMXplYXA3ak4yeitYbURJM3BVaXhpMGJiTUcrYXhKZkpDSWtIZUJuOFhUeWhjRGh4aVE1WmZYcmttRTdXOUF2bzVqM0JMbFl6MmdqNVgzaVhKNkhYekxKY2MzcGN5eXY5bHhJT1hFSXdRYnZLVm9neVNzL0lLZlVrRWQ5eXJoaDdXZ2pIMHJkNlhmQjUwazR4d0h5amhWQ0NpVDg2ejVIdUlpR3pBZkdzNTBraEY0eUJ0ODk5d2FMdi82em5OZTl3M2pLWk9CODE3ZFVuWGd0REJybEM0a3BxejY4ZUZtUkxoT05WQ3o0bU1OTXMvTWlSY1ZGdDFoYzVqZlRERXEwbnU4K2NNQVVDY2taSFRxVDlDL2JRQkNacG1HL0FzZUtpbUdGVkJDZGNPZHkwdy84bEZyWVF1QmVSMkoyL3hnTkFCTHhlRmUrMkl0QWUzR014U2c5RTg1NlNTTnQyeTlmcEZpM0FjM3ByTk5SQ1ZFZ0d6Y0ZkYmhMbHF3UUh1aEpHSiIsImRldmljZUlkIjoiYW16bjEuYXNrLmRldmljZS5BRlBOTzNaRjI1WTRWSzJONlJEV05XUjJHNklENU1ON1U3VzQ3V0wzSUJFS0xMRVVWS0NDQ0VSVlVHUjZVVkJQWkFWNFhHS1kyQ1czQjc1RVhQMllaTkdJWjNHSUJTQk1YUUdOVVlPQzNQU1ZHSVNGTk5ZVU4yVUNaS0pPRzJESTJLNTQ0QVBFVUJZUUJXUFNKNUpKMklaWlE0RlEiLCJ1c2VySWQiOiJhbXpuMS5hc2suYWNjb3VudC5BSFZVRUVSTElMQkJRUkdTTDM1TVIyV09DT1JWNTNYMjdETTdMNUQ3V0NZRTJISlpVTUJBUzZJV1FQN0VMS0dEWUJIVks0R01VR0k2WE81NEdFV1pHVUpLTlpOWEQ2UVNOVEg2NDRCWEZUTk5BTDVVSUpCMk5YNFQzVTNXN1dVWTM1NUtaVlpJRFJUUFYzV0hYWk1EWjdaRVJWN1RBRVNOSVhFQlhRQlgySUFJUlQ1VUEyWjM2NlZJWlJNMlNTRk1FUVhBMkhQNElYMkJSUVkifX0.fAQxv8X1m-N0FltruhnbqU-VehDeORwE5-ojWFzny0bbFt5h2YrzzlDHvwMmgTSYFtX-j649Lttv9oDYW13VN4_XzIMrZQNHeW095lIytQJXzfgDLXk_hNET6qC1LXyr-uMhvlNGWBM3yv05O__HbR2NKEdsncsdvdi7iSazIUkCCEqO_gLFiwuqLSDyfJaq9dRcTkuCPbg1knv2RR-vdyzpYuso5I2abyntnAVH6Dgx-21fVdXZEbS6s0LCM8BrKRbXYzV9nwdCFRp3TrayTfDKSBcXsjSyRusXDP2KMDv0_1Qr0nmVT8p5EILObdAukFal3hGxgyGJSuo_CKiacw""
		}
	},
	""request"": {
		""type"": ""IntentRequest"",
		""requestId"": ""amzn1.echo-api.request.5eebe367-7181-477b-94ae-bec639ade8d4"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-08-05T10:14:06Z"",
		""intent"": {
			""name"": ""BirthYearRequiredNoValidation"",
			""confirmationStatus"": ""NONE"",
			""slots"": {
				""fourDigitNumSlot"": {
					""name"": ""fourDigitNumSlot"",
					""value"": ""1950"",
					""confirmationStatus"": ""NONE"",
					""source"": ""USER""
				}
			}
		},
		""dialogState"": ""COMPLETED""
	}
}

";


    public static string SingleYear_NoValidation_NoDataSpecified => @"


{
	""version"": ""1.0"",
	""session"": {
		""new"": false,
		""sessionId"": ""amzn1.echo-api.session.f5c0d6da-d243-47ca-8b90-90b00a0a1104"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
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
				""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.AFPNO3ZF25Y4VK2N6RDWNWR2G6ID5MN7U7W47WL3IBEKLLEUVKCCCERVUGR6UVBPZAV4XGKY2CW3B75EXP2YZNGIZ3GIBSBMXQGNUYOC3PSVGISFNNYUN2UCZKJOG2DI2K544APEUBYQBWPSJ5JJ2IZZQ4FQ"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjcwMjM1Y2U3LTEzYmUtNDJkOS1iNjQ1LTI2YzNhYjIzNDM4MSIsImV4cCI6MTY1OTY5NDU3OCwiaWF0IjoxNjU5Njk0Mjc4LCJuYmYiOjE2NTk2OTQyNzgsInByaXZhdGVDbGFpbXMiOnsiY29udGV4dCI6IkFBQUFBQUFBQUFEQ1didlRsdmVKN3FaL3U5dmtMZ2pTSkFFQUFBQUFBQUNPdGZwY3dXam4rVTJybkNTVWZYcjJDODNiZUpZMmhWbXcrV2RXN2tTZFlxODZMbk9scTFzNkt1K0w3YjV2alJSdWcyLzQwbXRpY2RPMEJuL2t0RjMyQlVuQjM5eUdPaFVWRWJ3elVjT215UU5UaW1NTCtTY3hHbVoyMnUyZzViZ08yTnFySlc1NGk0S3FLa1lGS250V29lR2ZwSEJOWjVwMHUxVlFtUHJOMmNHa0pRVERjWk1jRlE4WWI2T3FMa09TN3V2empjampaTUhtOTBwNjVqREVWMk1hbUlOL25TUWg5NHcxMEZRSVAzKzNhdVdCb0x2ckNNRVJXa0xUTzBna3pFU0p2cVNOeWxWeWpPWWRZV0ZZQldRa0IvdHNLMFZXK2NNSXkvdjN0anBWMW0xVllzV1QxeUtFNXExT2RFaVB4N09jdDlLN0xMUzExNGd0SG00aGFocW5ZNE1Kb0JKWTBRNFdvOXh4SDA3Y2lQa3lnWWRyS241NytqbnRhZ2kwM2JvWSIsImRldmljZUlkIjoiYW16bjEuYXNrLmRldmljZS5BRlBOTzNaRjI1WTRWSzJONlJEV05XUjJHNklENU1ON1U3VzQ3V0wzSUJFS0xMRVVWS0NDQ0VSVlVHUjZVVkJQWkFWNFhHS1kyQ1czQjc1RVhQMllaTkdJWjNHSUJTQk1YUUdOVVlPQzNQU1ZHSVNGTk5ZVU4yVUNaS0pPRzJESTJLNTQ0QVBFVUJZUUJXUFNKNUpKMklaWlE0RlEiLCJ1c2VySWQiOiJhbXpuMS5hc2suYWNjb3VudC5BSFZVRUVSTElMQkJRUkdTTDM1TVIyV09DT1JWNTNYMjdETTdMNUQ3V0NZRTJISlpVTUJBUzZJV1FQN0VMS0dEWUJIVks0R01VR0k2WE81NEdFV1pHVUpLTlpOWEQ2UVNOVEg2NDRCWEZUTk5BTDVVSUpCMk5YNFQzVTNXN1dVWTM1NUtaVlpJRFJUUFYzV0hYWk1EWjdaRVJWN1RBRVNOSVhFQlhRQlgySUFJUlQ1VUEyWjM2NlZJWlJNMlNTRk1FUVhBMkhQNElYMkJSUVkifX0.bSBFt-pxRDqehd1x6pEo6naDQsBpyY933KVeeqj57hzAQaJqHwmECsH2vzCrhANOVXRhya-tWxMZMgVNRMDHBbgjI-UKCFxYsv0EMeCNRwG_LLWJV-Qr7x-W72iDvvQC-XO0i9pVwmCuceZDdHWyYANzDjmC6GHxMcma1NmrMbO6j9Kjg7CiCoX499TyMtbFg2V--X90UQ4ttMuXX6xGbcNYi1X2OQkzrqAOCSKUZW-V96HVrJl0EiTkbxvyt4OM5pBXprL71Oyw0xszI2CP0Kb4T2Wj5ns4fNM7IuRG1jHDJZJBmRV3ipmHP7_MSP6olZIv2M8yruMkiMDAwT26FQ""
		}
	},
	""request"": {
		""type"": ""IntentRequest"",
		""requestId"": ""amzn1.echo-api.request.010cf8be-e7ca-4354-9edd-5d56a19dc7b9"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-08-05T10:11:18Z"",
		""intent"": {
			""name"": ""BirthYearNoValidation"",
			""confirmationStatus"": ""NONE"",
			""slots"": {
				""fourDigitNumSlot"": {
					""name"": ""fourDigitNumSlot"",
					""confirmationStatus"": ""NONE""
				}
			}
		},
		""dialogState"": ""STARTED""
	}
}



";

    public static string MultiYearWithValidation_NoDataSpecified => @"

{
	""version"": ""1.0"",
	""session"": {
		""new"": false,
		""sessionId"": ""amzn1.echo-api.session.f62df09a-3143-4107-83e7-b4f59c8f1f09"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
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
				""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.AFPNO3ZF25Y4VK2N6RDWNWR2G6ID5MN7U7W47WL3IBEKLLEUVKCCCERVUGR6UVBPZAV4XGKY2CW3B75EXP2YZNGIZ3GIBSBMXQGNUYOC3PSVGISFNNYUN2UCZKJOG2DI2K544APEUBYQBWPSJ5JJ2IZZQ4FQ"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjcwMjM1Y2U3LTEzYmUtNDJkOS1iNjQ1LTI2YzNhYjIzNDM4MSIsImV4cCI6MTY1OTY5MDA4MSwiaWF0IjoxNjU5Njg5NzgxLCJuYmYiOjE2NTk2ODk3ODEsInByaXZhdGVDbGFpbXMiOnsiY29udGV4dCI6IkFBQUFBQUFBQUFEQ1didlRsdmVKN3FaL3U5dmtMZ2pTSkFFQUFBQUFBQUR2dTMwNEJNdHB4QTJkS1kzT2l6VHBMRitXVk9lMmZpUGxiTFdUV211OTNTWTBxMlg5RGpaVWRPdUNUaksxaFlKSU11WDRSVWt0a25ZYmsvdk9oaHNWMitrUGphWWJXa01SZTFUKzI4UTRaTzd3SWptMUlmdXhFcnhoU2lJWGVGdkNBRjMvamJDRmE3S2RMOUR3dXRsTy9KRmVwTEhXNWVsRndPUE5NOVVPT1pvWFY5cE9ad0hMSUUxdGFuSTkweHJZakxLWkVZU1U0OWhqTlc3RTlyZ2FoRFczQ3Q3YVBNTmFCU0tKMnM0ZXhWNEJQUzUwS3JRLzY1ZnRGbWFJOHdWSTN6dWxhY2RRK2w2emRFVk81OFBaSXV5YnA5Vi9RN2JBWHpSRHhQclpUcUEwcmNGWWRRdW8rdjhHQnZvYmVUZEJLZFR0TjNwdmxZcVp0QXR1eDZDbFp0U2xNMXo2NlMyUzd0SkplS3pFWUxXS2Q2dWhXaEppTUg2UkhhZ2QxL0wzNlo5USIsImRldmljZUlkIjoiYW16bjEuYXNrLmRldmljZS5BRlBOTzNaRjI1WTRWSzJONlJEV05XUjJHNklENU1ON1U3VzQ3V0wzSUJFS0xMRVVWS0NDQ0VSVlVHUjZVVkJQWkFWNFhHS1kyQ1czQjc1RVhQMllaTkdJWjNHSUJTQk1YUUdOVVlPQzNQU1ZHSVNGTk5ZVU4yVUNaS0pPRzJESTJLNTQ0QVBFVUJZUUJXUFNKNUpKMklaWlE0RlEiLCJ1c2VySWQiOiJhbXpuMS5hc2suYWNjb3VudC5BSFZVRUVSTElMQkJRUkdTTDM1TVIyV09DT1JWNTNYMjdETTdMNUQ3V0NZRTJISlpVTUJBUzZJV1FQN0VMS0dEWUJIVks0R01VR0k2WE81NEdFV1pHVUpLTlpOWEQ2UVNOVEg2NDRCWEZUTk5BTDVVSUpCMk5YNFQzVTNXN1dVWTM1NUtaVlpJRFJUUFYzV0hYWk1EWjdaRVJWN1RBRVNOSVhFQlhRQlgySUFJUlQ1VUEyWjM2NlZJWlJNMlNTRk1FUVhBMkhQNElYMkJSUVkifX0.WLUEbOoQCIZRmzitlsvfMACjrusYQEVTRrjoen47uNMQbwCXwp_cNgxX5bXNenUJXrnM6h9szibCYsYB_n0_DmNFKwpQjyWzc7qKfIGSVLbwETQR500XNxYRFf3pnhXjMQ_guOKe0SpINwAUU2GPKsFPwILinHqSVAlfz3wEoHYYzTNdWnF93XJOigLGYsMV5yciN8PTYCdSgknlQL7K7_UqPuRMzwIQ8l5PnoaGgtW2N4p7roYBGideldMffm7GfqjGBsCAZ25p3twxeAY_j2ye-8OtcNbGBldAAvDWVPPVhdxyvsnqqg5YIxW9Zwqb8oyprb5EE65Kv2Vukas7lA""
		}
	},
	""request"": {
		""type"": ""IntentRequest"",
		""requestId"": ""amzn1.echo-api.request.8ab04987-976a-495f-aec3-578e545b9203"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-08-05T08:56:22Z"",
		""intent"": {
			""name"": ""MultiYearWithValidation"",
			""confirmationStatus"": ""NONE"",
			""slots"": {
				""__Conjunction"": {
					""name"": ""__Conjunction"",
					""confirmationStatus"": ""NONE"",
					""source"": ""USER""
				},
				""fourDigitNumSlot"": {
					""name"": ""fourDigitNumSlot"",
					""confirmationStatus"": ""NONE"",
					""source"": ""USER""
				}
			}
		},
		""dialogState"": ""COMPLETED""
	}
}


";

    public static string IWasBornIn1950_SingleValue_WithValidation => @"


{
	""version"": ""1.0"",
	""session"": {
		""new"": false,
		""sessionId"": ""amzn1.echo-api.session.b2622512-ce01-4785-abb9-5e51b01d4459"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
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
				""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.AFPNO3ZF25Y4VK2N6RDWNWR2G6ID5MN7U7W47WL3IBEKLLEUVKCCCERVUGR6UVBPZAV4XGKY2CW3B75EXP2YZNGIZ3GIBSBMXQGNUYOC3PSVGISFNNYUN2UCZKJOG2DI2K544APEUBYQBWPSJ5JJ2IZZQ4FQ"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjcwMjM1Y2U3LTEzYmUtNDJkOS1iNjQ1LTI2YzNhYjIzNDM4MSIsImV4cCI6MTY1OTY4OTg0NCwiaWF0IjoxNjU5Njg5NTQ0LCJuYmYiOjE2NTk2ODk1NDQsInByaXZhdGVDbGFpbXMiOnsiY29udGV4dCI6IkFBQUFBQUFBQUFEQ1didlRsdmVKN3FaL3U5dmtMZ2pTSkFFQUFBQUFBQURNQ1FhTm5tWDNYT2Nna2FGa1NGaGU2UEM4UC8ycng1d3hqS2lTOUpZb1NHRlNuQ0NkRVBHb2lJaVRFd3R0MmtSQ05FUmFIcWE3VXVieDBTUlp3TXRwZkovN2VoUFlYWUlDVXVFS2srcHdaTWJxcDFEZGR4TWthM0gwWmJ5NGJSbXlNOGdPYVdRZ1hOK0RSamNIQU1XanFTc2hpSWxlLzRZUzVFRXljTjRyVWNKWWRGbldEbDhPTDlPYndXb0N0WUIyN0ZMK1EzWmZqSDMrWDJ3d1ArV3BKa3QvMXZTMGMvOW9jRCsvSUpOam9aRGFWN2luU3Q2ZUpjT1p4U1hoTEhoc1AxS0RBT1JWRkJFWTNzZCs3dHNEcGpnMnRmSG5xN1krN2dCSjBVMGxXTGxsQlQyZVFyT200cktTTWVCU0pMN2MrNzFhL3NTdXJNZThiNkxhNVIxaFRXN3FneHNveFZYMXV4Qm1hdEg1Mitpc1IralR4NzFMbTlSSEFscW1vZ1ljZEJKcCIsImRldmljZUlkIjoiYW16bjEuYXNrLmRldmljZS5BRlBOTzNaRjI1WTRWSzJONlJEV05XUjJHNklENU1ON1U3VzQ3V0wzSUJFS0xMRVVWS0NDQ0VSVlVHUjZVVkJQWkFWNFhHS1kyQ1czQjc1RVhQMllaTkdJWjNHSUJTQk1YUUdOVVlPQzNQU1ZHSVNGTk5ZVU4yVUNaS0pPRzJESTJLNTQ0QVBFVUJZUUJXUFNKNUpKMklaWlE0RlEiLCJ1c2VySWQiOiJhbXpuMS5hc2suYWNjb3VudC5BSFZVRUVSTElMQkJRUkdTTDM1TVIyV09DT1JWNTNYMjdETTdMNUQ3V0NZRTJISlpVTUJBUzZJV1FQN0VMS0dEWUJIVks0R01VR0k2WE81NEdFV1pHVUpLTlpOWEQ2UVNOVEg2NDRCWEZUTk5BTDVVSUpCMk5YNFQzVTNXN1dVWTM1NUtaVlpJRFJUUFYzV0hYWk1EWjdaRVJWN1RBRVNOSVhFQlhRQlgySUFJUlQ1VUEyWjM2NlZJWlJNMlNTRk1FUVhBMkhQNElYMkJSUVkifX0.hhPw07v0SZiT6QdT0w8LhUF7gqHEuTgdObvkkuUz5SX0JImui8Cx9q3MCQeeHidrWyNGRCD8wpvMteRWEZPpFTw4qXfPTL6-Lw51cxJq3QbyStgl-tcwtBP3wLAzAO13QnJgrwag7Ihm2CAtaawt5uQ9TinIRTuSISZXTBtXS6W7tGIZpGRNbh90A_2w9Ui_7FsORqQhYLVhyz5IwN2rgAAeS08THVClHlhwPBvBVVJ8HTuDHw70KHR4bLAMGx7AwZTZsfHamSAvhbdBEz5e0foy_gTiitAaN5Bh8QNg5mCyPEM9zVpC2gS1nhmnGn_Bi--eWo9vN5F2-7MPMxb_yQ""
		}
	},
	""request"": {
		""type"": ""IntentRequest"",
		""requestId"": ""amzn1.echo-api.request.707a9e14-191e-4bb1-970c-23a172e65425"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-08-05T08:52:24Z"",
		""intent"": {
			""name"": ""BirthYearIntentWithValidation"",
			""confirmationStatus"": ""NONE"",
			""slots"": {
				""fourDigitNumSlot"": {
					""name"": ""fourDigitNumSlot"",
					""value"": ""1950"",
					""confirmationStatus"": ""NONE"",
					""source"": ""USER""
				}
			}
		},
		""dialogState"": ""COMPLETED""
	}
}

";



    public static string MultipleValues_WithValidation => @"";



    public static string MultipleValues_NoValidation => @"

{
	""version"": ""1.0"",
	""session"": {
		""new"": false,
		""sessionId"": ""amzn1.echo-api.session.b2622512-ce01-4785-abb9-5e51b01d4459"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
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
				""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.AFPNO3ZF25Y4VK2N6RDWNWR2G6ID5MN7U7W47WL3IBEKLLEUVKCCCERVUGR6UVBPZAV4XGKY2CW3B75EXP2YZNGIZ3GIBSBMXQGNUYOC3PSVGISFNNYUN2UCZKJOG2DI2K544APEUBYQBWPSJ5JJ2IZZQ4FQ"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjcwMjM1Y2U3LTEzYmUtNDJkOS1iNjQ1LTI2YzNhYjIzNDM4MSIsImV4cCI6MTY1OTY4OTc4MSwiaWF0IjoxNjU5Njg5NDgxLCJuYmYiOjE2NTk2ODk0ODEsInByaXZhdGVDbGFpbXMiOnsiY29udGV4dCI6IkFBQUFBQUFBQUFEQ1didlRsdmVKN3FaL3U5dmtMZ2pTSkFFQUFBQUFBQUM1NUhEeTBsbWpYamZVOERBdnRCZEJremdaRm9BL0JWS25ZOUNDTm9GNWQza29ZbE1UZXJMeGwreTloRS9CWnI1bnlNUnczMGdRMnBiZis5alE1ajlWaEpGbncySzUzT3A1WFVSbkVyNHplTFBCcEpJb1BXOUdBNUtiblllMlF6ZTJjM3Iyc0dCUThBTkdKelFiRHpvRE8wVWtFUzdqTFE4Y01KU3FkYnJBeFhka0NRWWkvQXo2M1QzMDlwMDZkVDhnbllzakpJTFJXcWRHQ3pTci84aVhQcFlpYUlmMUdUa1RZUFRmUTRNZWw0c2xkRXlwNUNhWTZWZGZMVGlCZkwyd2FHWjBSK2xWUTZMT3lUMXVEdEk4MnM3Zm9TY1FLeVVzSnpLVDZ2TXZnbW5aYjkrbUZSREFhR0UrT3VGbkYvT3lGaHNBUXlPNy95K2lkeEJYSlh5NUFUWHBxVHdIbytwa3lNUGpkcWRZb0lBZ0FPNXYyZ1ZjMFkvbEdienlwREdnbWpuZSIsImRldmljZUlkIjoiYW16bjEuYXNrLmRldmljZS5BRlBOTzNaRjI1WTRWSzJONlJEV05XUjJHNklENU1ON1U3VzQ3V0wzSUJFS0xMRVVWS0NDQ0VSVlVHUjZVVkJQWkFWNFhHS1kyQ1czQjc1RVhQMllaTkdJWjNHSUJTQk1YUUdOVVlPQzNQU1ZHSVNGTk5ZVU4yVUNaS0pPRzJESTJLNTQ0QVBFVUJZUUJXUFNKNUpKMklaWlE0RlEiLCJ1c2VySWQiOiJhbXpuMS5hc2suYWNjb3VudC5BSFZVRUVSTElMQkJRUkdTTDM1TVIyV09DT1JWNTNYMjdETTdMNUQ3V0NZRTJISlpVTUJBUzZJV1FQN0VMS0dEWUJIVks0R01VR0k2WE81NEdFV1pHVUpLTlpOWEQ2UVNOVEg2NDRCWEZUTk5BTDVVSUpCMk5YNFQzVTNXN1dVWTM1NUtaVlpJRFJUUFYzV0hYWk1EWjdaRVJWN1RBRVNOSVhFQlhRQlgySUFJUlQ1VUEyWjM2NlZJWlJNMlNTRk1FUVhBMkhQNElYMkJSUVkifX0.TjYCJbQkU5DsN_be_-oJDwcQJaF0TCOAW0Gi8HftzSLptApi9fZ83pNkN7RDTutlUD1SkTkgP5RRJgEw_IG4Q_kQ0xySyNqeAyys_VO1gnwZDyuHBGM96VSKdbN05EHGgqhHKgyyd1mTo8WWVdE_rB0-m5pFluOcf_j3WH30pIURWU3H7Y9ZU8yBO1HfJWDrwHGFmj-UradVnFI-DIlh8j5-CAmhddiWjnTeImsPW-P5e96B0q5CJghOx0sOrQgXG2BWPYbtIK8TBlnlvwnHPJJ8Hi59a7bw7w9oe1VR60hRV-gAQnLjs47Uv-QrYeUT5znzMafRuImBSzCizdijTw""
		}
	},
	""request"": {
		""type"": ""IntentRequest"",
		""requestId"": ""amzn1.echo-api.request.2b21c9e0-0993-4594-81ca-ba976992702e"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-08-05T08:51:22Z"",
		""intent"": {
			""name"": ""MultiYearNoValidation"",
			""confirmationStatus"": ""NONE"",
			""slots"": {
				""__Conjunction"": {
					""name"": ""__Conjunction"",
					""value"": ""and"",
					""confirmationStatus"": ""NONE"",
					""source"": ""USER"",
					""slotValue"": {
						""type"": ""Simple"",
						""value"": ""and""
					}
				},
				""fourDigitNumSlot"": {
					""name"": ""fourDigitNumSlot"",
					""confirmationStatus"": ""NONE"",
					""source"": ""USER"",
					""slotValue"": {
						""type"": ""List"",
						""values"": [
							{
								""type"": ""Simple"",
								""value"": ""1950""
							},
							{
								""type"": ""Simple"",
								""value"": ""1960""
							}
						]
					}
				}
			}
		},
		""dialogState"": ""STARTED""
	}
}

";


	public static string IWasBornIn1950_SingleValue_NoValidation => @"


{
	""version"": ""1.0"",
	""session"": {
		""new"": false,
		""sessionId"": ""amzn1.echo-api.session.b2622512-ce01-4785-abb9-5e51b01d4459"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
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
				""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.AFPNO3ZF25Y4VK2N6RDWNWR2G6ID5MN7U7W47WL3IBEKLLEUVKCCCERVUGR6UVBPZAV4XGKY2CW3B75EXP2YZNGIZ3GIBSBMXQGNUYOC3PSVGISFNNYUN2UCZKJOG2DI2K544APEUBYQBWPSJ5JJ2IZZQ4FQ"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjcwMjM1Y2U3LTEzYmUtNDJkOS1iNjQ1LTI2YzNhYjIzNDM4MSIsImV4cCI6MTY1OTY4OTYxOCwiaWF0IjoxNjU5Njg5MzE4LCJuYmYiOjE2NTk2ODkzMTgsInByaXZhdGVDbGFpbXMiOnsiY29udGV4dCI6IkFBQUFBQUFBQUFEQ1didlRsdmVKN3FaL3U5dmtMZ2pTSkFFQUFBQUFBQURjUW1LN2poTzBiR0JSREg3bVVRMWNjMU1WZ3Zhb3ZYMVJPOWVOVkRNenlOUXliV2FiNHFXUUhmOEFIWHVQMUczTTZTTXZDWmlQeEtMaXpsUUFydFB3ZlIrSWVnVmN2VWdQQ21yaWFvMWxOTng1RVREV0tiWk9wRzc5MjJXeHVRZnlwMWRTS2FEcjdDTktzTXdhTDRwOXQ4S0hJS09LZ0pTMTczQjQxU1IySW5SRUNHMEpjaXZRUVd5eEJqdWVsVzE3S3N3TlRUYm9vV3hzTEVOWVhWWWdVVnRzaHFpZDVoZUg4Rkp4QTh3UzlYUUhPdEtyTFJBM3BoNnZpWS96ZGhuRzNYOXdLMVUzVDZSNWZicjk2aFBWNjg3UmoybnJVNTFUU0JwNlRmVGNUNlJoZHFkRllHWjlsOFdSOWFQbG9ISlNsSmJnajYxeWNrbk0yK0dLTHBrYlBIS3ZEcUhkR1R5bHBxTTFiNnZhcnAwb0JwQzJCREdTTklZajFaVldSVUptdFExOCIsImRldmljZUlkIjoiYW16bjEuYXNrLmRldmljZS5BRlBOTzNaRjI1WTRWSzJONlJEV05XUjJHNklENU1ON1U3VzQ3V0wzSUJFS0xMRVVWS0NDQ0VSVlVHUjZVVkJQWkFWNFhHS1kyQ1czQjc1RVhQMllaTkdJWjNHSUJTQk1YUUdOVVlPQzNQU1ZHSVNGTk5ZVU4yVUNaS0pPRzJESTJLNTQ0QVBFVUJZUUJXUFNKNUpKMklaWlE0RlEiLCJ1c2VySWQiOiJhbXpuMS5hc2suYWNjb3VudC5BSFZVRUVSTElMQkJRUkdTTDM1TVIyV09DT1JWNTNYMjdETTdMNUQ3V0NZRTJISlpVTUJBUzZJV1FQN0VMS0dEWUJIVks0R01VR0k2WE81NEdFV1pHVUpLTlpOWEQ2UVNOVEg2NDRCWEZUTk5BTDVVSUpCMk5YNFQzVTNXN1dVWTM1NUtaVlpJRFJUUFYzV0hYWk1EWjdaRVJWN1RBRVNOSVhFQlhRQlgySUFJUlQ1VUEyWjM2NlZJWlJNMlNTRk1FUVhBMkhQNElYMkJSUVkifX0.V8GtDfhb2PXNDqJQEuMybn_SdNkPIlysjj2swrYTKRUwF2GcLsfBXC8NltVQK3eU4XMfeJfErIUBSz0YHbtC1KRBlQ2T8roJUCJTBXxSiwNTdpzq_bya5sM4M9N5ti1K7Br8COEOc0xBAaXAwUmLpeN47lhZrDQjfQd5ZtTlWDi6OunY_Vke4osyq-aLaxZDE62QiJVENdHR93_06UVuzw9qHzmFa3PkPv-Gcz2DLD6vWh6Gf2t9mwFWKwavbrZxTyN_JVdDIL_IXGpORT8JRpew2sVFJNDSL865aoJjyy0FzE9J8Hus-NnfM2MvtUc-V_-NCLLUsD8y4GrCc8LnDQ""
		}
	},
	""request"": {
		""type"": ""IntentRequest"",
		""requestId"": ""amzn1.echo-api.request.959a2233-69cd-475b-867b-32ea936ffe41"",
		""locale"": ""en-US"",
		""timestamp"": ""2022-08-05T08:48:38Z"",
		""intent"": {
			""name"": ""BirthYearNoValidation"",
			""confirmationStatus"": ""NONE"",
			""slots"": {
				""fourDigitNumSlot"": {
					""name"": ""fourDigitNumSlot"",
					""value"": ""1950"",
					""confirmationStatus"": ""NONE"",
					""source"": ""USER"",
					""slotValue"": {
						""type"": ""Simple"",
						""value"": ""1950""
					}
				}
			}
		},
		""dialogState"": ""STARTED""
	}
}


";



    public static string TooManyRepromptsForValidSlotValue => @"


{
	""version"": ""1.0"",
	""session"": {
		""new"": false,
		""sessionId"": ""amzn1.echo-api.session.a023dc82-2ade-453b-98ad-679915409b53"",
		""application"": {
			""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
		},
		""attributes"": {},
		""user"": {
			""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
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
				""applicationId"": ""amzn1.ask.skill.70235ce7-13be-42d9-b645-26c3ab234381""
			},
			""user"": {
				""userId"": ""amzn1.ask.account.AHVUEERLILBBQRGSL35MR2WOCORV53X27DM7L5D7WCYE2HJZUMBAS6IWQP7ELKGDYBHVK4GMUGI6XO54GEWZGUJKNZNXD6QSNTH644BXFTNNAL5UIJB2NX4T3U3W7WUY355KZVZIDRTPV3WHXZMDZ7ZERV7TAESNIXEBXQBX2IAIRT5UA2Z366VIZRM2SSFMEQXA2HP4IX2BRQY""
			},
			""device"": {
				""deviceId"": ""amzn1.ask.device.AFPNO3ZF25Y4VK2N6RDWNWR2G6ID5MN7U7W47WL3IBEKLLEUVKCCCERVUGR6UVBPZAV4XGKY2CW3B75EXP2YZNGIZ3GIBSBMXQGNUYOC3PSVGISFNNYUN2UCZKJOG2DI2K544APEUBYQBWPSJ5JJ2IZZQ4FQ"",
				""supportedInterfaces"": {}
			},
			""apiEndpoint"": ""https://api.amazonalexa.com"",
			""apiAccessToken"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjcwMjM1Y2U3LTEzYmUtNDJkOS1iNjQ1LTI2YzNhYjIzNDM4MSIsImV4cCI6MTY1OTY4NzE0OCwiaWF0IjoxNjU5Njg2ODQ4LCJuYmYiOjE2NTk2ODY4NDgsInByaXZhdGVDbGFpbXMiOnsiY29udGV4dCI6IkFBQUFBQUFBQUFEQ1didlRsdmVKN3FaL3U5dmtMZ2pTSkFFQUFBQUFBQUN5UGdDMktVUWh2Y09JNVFwRS9NaHUzekxtdkpuZEQvQ1R0VGMvZUdiaUNPWGQ5YjdXRkI1eXJDK1lWYVp0YlRKc1cycjloNytvQUZXSmJwUldCNGR4OU1MN0p5cmhlWnZpQm00N1cwQkhqSG5EaWtYQmhHUVFLWUhQRUFvVTdvbjNyVWdvRTI0bWFPWS85dURSalJXN1dDWHlsWVY3NS9WU1ZtbU1KVjk2QzRsRXZ4QUZNS2c0aE1qMEZSRzYvMDYzUENLQm5XOTh2dUYxeGxKczhVTmtrUEFEYzVCY3M0NVdpdmoxaGp5czVNWHpHNW5udkNreHdwZG9MOWZWMThqTGdBemY5UFJ0Ym5kMUF0S3F0ZXVBdWZlcnF0Z1BBckZuN2ZwdGdSOVh3NlpMSkN1UUE3b2NReG9wQnBBUG84cHVTYlJ2U1gyS2VvcVF1SStDMFhwVmlRZHQ3YkRMeGoyZk8xMVo2UGFTTkd6cE9iWktZaDh6dXk1bDVoSnl1eksvWnhyRSIsImRldmljZUlkIjoiYW16bjEuYXNrLmRldmljZS5BRlBOTzNaRjI1WTRWSzJONlJEV05XUjJHNklENU1ON1U3VzQ3V0wzSUJFS0xMRVVWS0NDQ0VSVlVHUjZVVkJQWkFWNFhHS1kyQ1czQjc1RVhQMllaTkdJWjNHSUJTQk1YUUdOVVlPQzNQU1ZHSVNGTk5ZVU4yVUNaS0pPRzJESTJLNTQ0QVBFVUJZUUJXUFNKNUpKMklaWlE0RlEiLCJ1c2VySWQiOiJhbXpuMS5hc2suYWNjb3VudC5BSFZVRUVSTElMQkJRUkdTTDM1TVIyV09DT1JWNTNYMjdETTdMNUQ3V0NZRTJISlpVTUJBUzZJV1FQN0VMS0dEWUJIVks0R01VR0k2WE81NEdFV1pHVUpLTlpOWEQ2UVNOVEg2NDRCWEZUTk5BTDVVSUpCMk5YNFQzVTNXN1dVWTM1NUtaVlpJRFJUUFYzV0hYWk1EWjdaRVJWN1RBRVNOSVhFQlhRQlgySUFJUlQ1VUEyWjM2NlZJWlJNMlNTRk1FUVhBMkhQNElYMkJSUVkifX0.E2wdYDSQXcGRq-KfeQ2Zf3mZ8KRHvdqPSHGjG90pmSP4kQCuAOPEp9u-VxeOiOr9X4XkIsWYia1zNwpji8mV6Eul9KI0oGk290_xqhzIumEalByUo1Umbcnqws11EeqQ5fZ85xbOXjiV_Pi8cR-gbR3MuNOdYfRR-o-AAym8hqtciUPscLGGOFHWzaNMiz1c28DtzvDtp4joVHkRhM754_IVfRJRuhsSDeo5sLI-4hOez1CY_3GaDkIIpgaOpcgbZB4smqvsYSNAcPjw_IHoq91l8UZDeY5TEcVgxKnmBUHgdyZCFMG6j58DHyMc5hPjh_Emx044JAyZb5MmxdMB3Q""
		}
	},
	""request"": {
		""type"": ""SessionEndedRequest"",
		""requestId"": ""amzn1.echo-api.request.17958051-a9ae-45aa-bd8f-06b85e3e4886"",
		""timestamp"": ""2022-08-05T08:07:28Z"",
		""locale"": ""en-US"",
		""reason"": ""EXCEEDED_MAX_REPROMPTS""
	}
}


";


}