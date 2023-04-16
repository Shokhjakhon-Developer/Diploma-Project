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
        Guid g = Guid.NewGuid();
        string guidString = Convert.ToBase64String(g.ToByteArray());
        guidString = guidString.Replace("=", "");
        guidString = guidString.Replace("+", "");
        return guidString;
    }

    public static AppConfig GetAppConfig()
    {
        string jsonData = File.ReadAllText(Directory.GetCurrentDirectory() + @"..\..\..\..\appSettings.json");
        var appConfig = JsonConvert.DeserializeObject<AppConfig>(jsonData);
        return appConfig;
    }
}