using Selenium_Wrapper.Element_Wrapper.Elements;
using Selenium_Wrapper.Utilities;

namespace Pages.Pages;

public abstract class BasePage
{
    protected string Name { get; }

    protected BaseElement UniqueElement { get; set; }

    protected BasePage(string name)
    {
        Name = name;
    }

    public bool IsPageOpened()
    {
        var isPageOpened = UniqueElement.IsDisplayed();
        LLogger.Instance.Info($"{Name} is opened: {isPageOpened}.");
        return isPageOpened;
    }
}

public abstract class BaseMap
{
    public BaseElement UniqueElement { get; set; }
}