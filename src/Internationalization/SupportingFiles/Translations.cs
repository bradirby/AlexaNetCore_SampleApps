using AlexaNetCore;
using AlexaNetCore.Model;

namespace AlexaNetCore.ZeroToHero.Internationalization
{
    internal static class Translations
    {
        public static AlexaMultiLanguageText SkillInvocation => 
            new AlexaMultiLanguageText("zero to hero test", AlexaLocale.English_US)
                .AddText("prova zero a hero", AlexaLocale.Italian)
                .AddText("prueba zero a hero", AlexaLocale.Spanish_ES);

        public static class IntentInvocations
        {
            /// <summary>
            /// I can speak many languages!
            /// </summary>
            public static AlexaMultiLanguageText CanYouSpeakInEglish=> 
                new AlexaMultiLanguageText("what languages are you trained with", AlexaLocale.English_US)
                    .AddText("in quali lingue ti sei formato", AlexaLocale.Italian)
                    .AddText("en que idiomas esta entrenado", AlexaLocale.Spanish_ES);
        }


        internal static class IntentPrompts
        {

            /// <summary>
            /// Welcome, you can say Hello or Help.  Which would you like to try?
            /// </summary>
            public static AlexaMultiLanguageText LaunchHandlerGreeting => 
                new AlexaMultiLanguageText("Welcome, say 'what languages are you trained with'.", AlexaLocale.English_US)
                    .AddText("Benvenuto, dì 'in quali lingue ti sei formato'?", AlexaLocale.Italian)
                    .AddText("Bienvenido, diga 'en qué idiomas está entrenado'?", AlexaLocale.Spanish_ES);

            /// <summary>
            /// Did you need some help?
            /// </summary>
            public static AlexaMultiLanguageText YesICanSpeakYourLanguage => 
                new AlexaMultiLanguageText("I can speak English! Also Spanish and Italian.", AlexaLocale.English_US)
                    .AddText("Parlo inglese, spagnolo e italiano", AlexaLocale.Italian)
                    .AddText("Hablo ingles, espanol y italiano.", AlexaLocale.Spanish_ES);
            

            /// <summary>
            /// Did you need some help?
            /// </summary>
            public static AlexaMultiLanguageText LaunchHandlerReprompt => 
                new AlexaMultiLanguageText("Did you need some help?", AlexaLocale.English_US)
                    .AddText("Avevi bisogno di aiuto?", AlexaLocale.Italian)
                    .AddText("Necesitabas ayuda?", AlexaLocale.Spanish_ES);


            /// <summary>
            /// You can say hello to me!  How can I help?
            /// </summary>
            public static AlexaMultiLanguageText HelpHandlerText => 
                new AlexaMultiLanguageText("You can say 'what languages are you trained with'", AlexaLocale.English_US)
                    .AddText("Puoi dire 'in quali lingue ti sei formato'?", AlexaLocale.Italian)
                    .AddText("Puedes decir 'en qué idiomas estás entrenado'?", AlexaLocale.Spanish_ES);


            /// <summary>
            /// Did you need some more time?
            /// </summary>
            public static AlexaMultiLanguageText HelpHandlerReprompt => 
                new AlexaMultiLanguageText("Did you need some more time?", AlexaLocale.English_US)
                    .AddText("Avevi bisogno di un po' più di tempo?", AlexaLocale.Italian)
                    .AddText("Necesitabas más tiempo?", AlexaLocale.Spanish_ES);


            /// <summary>
            /// Goodbye
            /// </summary>
            public static AlexaMultiLanguageText EndSessionText => 
                new AlexaMultiLanguageText("Goodbye", AlexaLocale.English_US)
                    .AddText("Arrivederci", AlexaLocale.Italian)
                    .AddText("Adiós", AlexaLocale.Spanish_ES);

            /// <summary>
            /// Goodbye
            /// </summary>
            public static AlexaMultiLanguageText NotSureWhatHappened => 
                new AlexaMultiLanguageText("Sorry, I didn't really get that.  Can you give it another shot?", AlexaLocale.English_US)
                    .AddText("Arrivederci", AlexaLocale.Italian)
                    .AddText("Adiós", AlexaLocale.Spanish_ES);
         

            /// <summary>
            /// I'm sorry, something went wrong.  Can you try again?
            /// </summary>
            public static AlexaMultiLanguageText SomethingWentWrong => 
                new AlexaMultiLanguageText("I am sorry, something went wrong.  Can you try again?", AlexaLocale.English_US)
                    .AddText("Scusa, non ho capito. Puoi provare di nuovo??", AlexaLocale.Italian)
                    .AddText("Lo siento, no entendí eso. puedes intentarlo de nuevo?", AlexaLocale.Spanish_ES);

        }



    }
}
