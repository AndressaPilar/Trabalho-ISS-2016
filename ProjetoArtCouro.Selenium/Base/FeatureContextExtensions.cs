using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace ProjetoArtCouro.Selenium.Base
{
    public static class FeatureContextExtensions
    {
        public static IWebDriver WebDriver(this FeatureContext context) => context.Get<IWebDriver>();
        public static void WebDriver(this FeatureContext context, IWebDriver driver) => context.Set(driver);

        public static WebDriverWait Wait(this FeatureContext context) => context.Get<WebDriverWait>();
        public static void Wait(this FeatureContext context, WebDriverWait wait) => context.Set(wait);

        public static string ApplicationUrl(this FeatureContext context) => context.Get<string>(FeatureContextKeyConstants.ApplicationUrlKey);
        public static void ApplicationUrl(this FeatureContext context, string configuration) => context.Add(FeatureContextKeyConstants.ApplicationUrlKey, configuration);

        public static string GlobalUser(this FeatureContext context) => context.Get<string>(FeatureContextKeyConstants.GlobalUserKey);
        public static void GlobalUser(this FeatureContext context, string configuration) => context.Add(FeatureContextKeyConstants.GlobalUserKey, configuration);

        public static string GlobalPassword(this FeatureContext context) => context.Get<string>(FeatureContextKeyConstants.GlobalPasswordKey);
        public static void GlobalPassword(this FeatureContext context, string configuration) => context.Add(FeatureContextKeyConstants.GlobalPasswordKey, configuration);
    }
}