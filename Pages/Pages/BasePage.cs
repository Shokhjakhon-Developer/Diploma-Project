using OpenQA.Selenium;
using Utilities.Utilities;

namespace Pages.Pages;

public abstract class BasePage
{
    protected string Name { get; }


    protected abstract IWebElement UniqueElement { get; }

    protected BasePage(string name, IWebDriver driver)
    {
        Name = name;
    }

    public bool IsPageOpened()
    {
        var isPageOpened = UniqueElement.Displayed;
        LLogger.Instance.Info($"{Name} is opened: {isPageOpened}.");
        return isPageOpened;
    }
}

public abstract class BaseMap
{
    public abstract IWebElement UniqueElement { get; }

    private readonly IWebDriver _driver;

    protected BaseMap(IWebDriver driver)
    {
        _driver = driver;
    }

    protected IWebDriver GetWebDriver => _driver;
}