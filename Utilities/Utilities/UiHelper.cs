using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Utilities.Utilities;

public class UiHelper
{
    public static IWebElement FindElementWithWait(IWebDriver driver, By locator)
    {
        var webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        var element = webDriverWait.Until(e => e.FindElement(locator));
        return element;
    }

    public static void ClearAndSendKeys(IWebElement element, string text)
    {
        element.Clear();
        element.SendKeys(text);
    }

    public static AppConfig GetAppConfig()
    {
        string jsonData = File.ReadAllText(Directory.GetCurrentDirectory() + @"..\..\..\..\appSettings.json");
        var appConfig = JsonConvert.DeserializeObject<AppConfig>(jsonData);
        return appConfig;
    }
}