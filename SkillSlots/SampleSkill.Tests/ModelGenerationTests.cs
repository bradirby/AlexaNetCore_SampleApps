using System;
using System.IO;
using System.Text.Json;
using NUnit.Framework;

namespace SkillSlots.Tests
{
    /// <summary>
    /// These tests are all explicit and are used to generate the various supporting files.  Run
    /// them when you want to regenerate the files
    /// </summary>
    public class ModelGenerationTests
    {
      

        [Test]
        [Explicit]
        public void CreateInteractionModelFile()
        {
            var skill = new BirthdayEchoSkill();
            var interactionModelObj = skill.GetInteractionModel();
            var interactionModelStr = JsonSerializer.Serialize(interactionModelObj);

            var filePath = Environment.GetEnvironmentVariable("AlexaNetCoreSampleProjectSkillSlots");
            filePath = Path.Combine(filePath, "SampleSkill\\SupportingFiles\\InteractionModelEnglish.json");
            File.WriteAllText(filePath, interactionModelStr);
        }
    }
}