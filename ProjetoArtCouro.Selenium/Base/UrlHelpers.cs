using TechTalk.SpecFlow;

namespace ProjetoArtCouro.Selenium.Base
{
    public class UrlHelpers
    {
        private static string Base { get; } = $"{FeatureContext.Current.ApplicationUrl()}";

        public static string Main { get; } = $"{Base}/";
        public static string Login { get; } = $"{Base}/Login/Login";
    }
}