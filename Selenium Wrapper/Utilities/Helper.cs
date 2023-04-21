using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Wrapper.Utilities;

public class Helper
{ 
    public static IWebElement FindElementWithWait(IWebDriver driver, By locator)
    {
        var webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        var element = webDriverWait.Until(e => e.FindElement(locator));
        return element;
    }

    public static string GenUniqueRandomString()
    {
        var guid = Guid.NewGuid();
        var randomStr = guid.ToString();
        return randomStr;
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

    public static string GetUniqueRandomStringWithLength(int n)
    {
        var str = GenUniqueRandomString();
        var limitedStr = str[..n];
        return limitedStr;
    }
}