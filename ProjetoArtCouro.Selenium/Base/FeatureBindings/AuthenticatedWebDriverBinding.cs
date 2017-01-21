using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using ProjetoArtCouro.Selenium.Helpers;

namespace ProjetoArtCouro.Selenium.Base.FeatureBindings
{
    [Binding]
    public sealed class AuthenticatedWebDriverBinding
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            var appSettings = ConfigurationManager.AppSettings;

            FeatureContext.Current.ApplicationUrl(appSettings[FeatureContextKeyConstants.ApplicationUrlKey]);
            FeatureContext.Current.GlobalUser(appSettings[FeatureContextKeyConstants.GlobalUserKey]);
            FeatureContext.Current.GlobalPassword(appSettings[FeatureContextKeyConstants.GlobalPasswordKey]);

            var driver = BuildWebDriver();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            ExecuteLogin(driver);

            FeatureContext.Current.WebDriver(driver);
            FeatureContext.Current.Wait(wait);
        }

        private static void ExecuteLogin(IWebDriver driver)
        {
            String teste = UrlHelpers.Login;
            Console.WriteLine("URL de Login "+teste);
            driver.Navigate().GoToUrl(UrlHelpers.Login);
            driver.FindElement(By.Name("UsuarioNome")).SendKeys(FeatureContext.Current.GlobalUser());
            driver.FindElement(By.Name("Senha")).SendKeys(FeatureContext.Current.GlobalPassword());
            driver.FindElement(By.Id("Login")).Click();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            FeatureContext.Current.WebDriver().Quit();
        }

        private static IWebDriver BuildWebDriver()
        {
            const string remoteUrl = "http://192.168.198.26:4444/wd/hub";

            EBrowser browser;
            Enum.TryParse(ConfigurationManager.AppSettings.Get("Browser"), true, out browser);

            IWebDriver driver;
            switch (browser)
            {
                case EBrowser.Chrome:
                    driver = new ChromeDriver();
                    break;
                case EBrowser.InternetExplorer:
                    driver = new InternetExplorerDriver();
                    break;
                case EBrowser.Edge:
                    driver = new EdgeDriver();
                    break;
                case EBrowser.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case EBrowser.PhantomJs:
                    driver = new PhantomJSDriver();
                    break;
                case EBrowser.HtmlUnit:
                    driver = new RemoteWebDriver(new Uri(remoteUrl), DesiredCapabilities.HtmlUnit());
                    break;
                case EBrowser.ChromeRemote:
                    driver = new RemoteWebDriver(new Uri(remoteUrl), DesiredCapabilities.Chrome());
                    break;
                case EBrowser.FirefoxRemote:
                    driver = new RemoteWebDriver(new Uri(remoteUrl), DesiredCapabilities.Firefox());
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}