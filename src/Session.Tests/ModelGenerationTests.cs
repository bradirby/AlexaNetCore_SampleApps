using System;
using System.IO;
using System.Text.Json;
using AlexaNetCore;
using AlexaNetCore.Model;
using NUnit.Framework;

namespace AlexaNetCore.ZeroToHero.Session.Tests
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
            var filePath = Environment.GetEnvironmentVariable("AlexaNetCoreSampleAppSourceCodeRootFolder");
            filePath ??= "";
            filePath = Path.Combine(filePath, "Session\\SupportingFiles\\InteractionModels");

            var skill = new SessionDemoSkill();
            
            var locale = AlexaLocale.English_US;
            File.WriteAllText(Path.Combine(filePath, $"{locale.LocaleString}.json"), 
                JsonSerializer.Serialize(skill.ValidateInteractionModel(locale).GetInteractionModel(locale)));


        }
    }
}