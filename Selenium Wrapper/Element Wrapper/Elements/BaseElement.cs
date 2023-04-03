using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium_Wrapper.Driver_Wrapper.Browser;
using Selenium_Wrapper.Utilities;

namespace Selenium_Wrapper.Element_Wrapper.Elements;

public class BaseElement
{
    protected string Name { get; }
    protected By Locator { get; }

    private WebDriver WebDriver => BrowserService.Browser.WebDriver;


    protected BaseElement(String name, By locator)
    {
        Name = name;
        Locator = locator;
    }

    protected IWebElement GetElement()
    {
        var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
        var element = wait.Until(e => e.FindElement(Locator));
        return element;
    }

    public void Click()
    {
        GetElement().Click();
        LLogger.Instance.Info($"{Name} was clicked.");
    }

    public string GetText()
    {
        var text = GetElement().Text;
        LLogger.Instance.Info($"\"{text}\" was received from {Name}.");
        return text;
    }

    public bool IsDisplayed()
    {
        var isDisplayed = GetElement().Displayed;
        LLogger.Instance.Info($"{Name} is displayed: {isDisplayed}.");
        return isDisplayed;
    }
}