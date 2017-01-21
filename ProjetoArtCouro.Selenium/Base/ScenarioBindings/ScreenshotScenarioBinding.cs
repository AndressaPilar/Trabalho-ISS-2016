using System;
using System.Drawing.Imaging;
using System.IO;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ProjetoArtCouro.Selenium.Base.ScenarioBindings
{
    [Binding]
    public class ScreenshotScenarioBinding
    {
        private const string ScreenshotFolder = @"C:\Selenium\Screenshots\";

        private const string Error = "ERROR";
        private const string Success = "SUCCESS";

        [AfterScenario]
        public static void AfterScenario()
        {
            PrepareForScreenshot();

            var screenshotDriver = FeatureContext.Current.WebDriver() as ITakesScreenshot;

            if (screenshotDriver == null)
            {
                return;
            }

            var testResult = ScenarioContext.Current.TestError != null ? Error : Success;
            var screenshotName = $"{ScenarioContext.Current.ScenarioInfo.Title}_{testResult}_{DateTime.Now:d-M-yyyy HHmmss}.png";
            screenshotDriver.GetScreenshot().SaveAsFile($"{ScreenshotFolder} {screenshotName}", ImageFormat.Png);
        }

        private static void PrepareForScreenshot()
        {
            if (!Directory.Exists(ScreenshotFolder))
            {
                Directory.CreateDirectory(ScreenshotFolder);
            }
        }
    }
}
