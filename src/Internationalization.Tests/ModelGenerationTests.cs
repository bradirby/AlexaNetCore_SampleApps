using System;
using System.IO;
using System.Text.Json;
using AlexaNetCore;
using AlexaNetCore.Model;
using NUnit.Framework;

namespace AlexaNetCore.ZeroToHero.Internationalization.Tests
{
    /// <summary>
    /// These tests are all explicit and are used to generate the various supporting files.
    /// Run them when you want to regenerate the files
    /// </summary>
    public class ModelGenerationTests
    {
        [Test]
        [Explicit]
        public void CreateInteractionModelFile()
        {
            //set this filepath to where you want the integration model JSON to be written
            //it's convenient to use an environment setting so the project can be shared easily with others
            var filePath = Environment.GetEnvironmentVariable("AlexaNetCoreSampleAppSourceCodeRootFolder");
            filePath ??= "";
            filePath = Path.Combine(filePath, "Internationalization\\SupportingFiles\\InteractionModels");

            var skill = new InternationalizationSkill();
            
            var locale = AlexaLocale.English_US;
            File.WriteAllText(Path.Combine(filePath, $"{locale.LocaleString}.json"), 
                JsonSerializer.Serialize(skill.ValidateInteractionModel(locale).GetInteractionModel(locale)));

            locale = AlexaLocale.Italian;
            File.WriteAllText(Path.Combine(filePath, $"{locale.LocaleString}.json"), 
                JsonSerializer.Serialize(skill.ValidateInteractionModel(locale).GetInteractionModel(locale)));

            locale = AlexaLocale.Spanish_ES;
            File.WriteAllText(Path.Combine(filePath, $"{locale.LocaleString}.json"), 
                JsonSerializer.Serialize(skill.ValidateInteractionModel(locale).GetInteractionModel(locale)));

        }
    }
}