using System;
using System.IO;
using System.Text.Json;
using AlexaNetCore;
using AlexaNetCore.Model;
using NUnit.Framework;
using AlexaNetCore.ZeroToHero.Interceptors;

namespace AlexaNetCore.ZeroToHero.Interceptors.Tests
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
            var filePath = Environment.GetEnvironmentVariable("AlexaNetCoreSourceCodeRootFolder");
            filePath ??= "";
            filePath = Path.Combine(filePath, "Samples\\Zero2Hero\\Step03_Interceptors\\SupportingFiles\\InteractionModels");

            var skill = new InterceptorSkill();
            
            var locale = AlexaLocale.English_US;
            File.WriteAllText(Path.Combine(filePath, $"{locale.LocaleString}.json"), 
                JsonSerializer.Serialize(skill.ValidateInteractionModel(locale).GetInteractionModel(locale)));

          

        }
    }
}