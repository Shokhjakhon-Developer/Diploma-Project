using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Wrapper.Browser.Browser_options;
using Utilities.Utilities;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Selenium_Wrapper.Browser.Browser;

public class Browser
{
    private readonly IWebDriver _driver;

    public Browser()
    {
        var browser = Helper.GetAppConfig().Driver.Browser;
        switch (browser)
        {
            case "chrome":
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(),
                    VersionResolveStrategy.MatchingBrowser);
                _driver = new ChromeDriver(BrowserOptions.GetChromeOptions());
                break;
            }
            default: throw new ArgumentException($"{browser} is not supported.");
        }
    }

    public void GoToUrl(string link)
    {
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl(link);
    }

    public void GoToUrl(Uri link)
    {
        GoToUrl(link.ToString());
    }

    public IWebDriver BrowserInit()
    {
        GoToUrl(Helper.GetAppConfig().Driver.Link);
        return _driver;
    }
}