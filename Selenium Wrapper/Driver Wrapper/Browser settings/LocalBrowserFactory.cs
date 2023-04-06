using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Selenium_Wrapper.Driver_Wrapper.Browser_settings;

public class LocalBrowserFactory : BrowserFactory
{
    public LocalBrowserFactory(BrowserProfile browserProfile) : base(browserProfile)
    {
    }

    protected override WebDriver WebDriver
    {
        get
        {
            var browserName = "chrome";
            var driverSettings = BrowserProfile.DriverSettings;

            switch (browserName)
            {
                case "chrome":
                    var options = (ChromeOptions)driverSettings.DriverOption;
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
                    WebDriver webDriver = new ChromeDriver(options);
                    return webDriver;
                default:
                    throw new InvalidEnumArgumentException($"WebDriver for browser {browserName} is not supported");
            }
        }
    }
}