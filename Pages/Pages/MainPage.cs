using OpenQA.Selenium;
using Utilities.Utilities;

namespace Pages.Pages;

public class MainPage : BasePage
{
    private readonly MainPageMap _map;

    public MainPage(string name, IWebDriver driver) : base(name, driver)
    {
        _map = new MainPageMap(driver);
    }

    public void ClickLoginButton()
    {
        _map.LoginBtn.Click();
    }

    protected override IWebElement UniqueElement => _map.UniqueElement;
}

internal class MainPageMap : BaseMap
{
    public MainPageMap(IWebDriver driver) : base(driver)
    {
    }

    public override IWebElement UniqueElement =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//h1[contains(@class,\"text-white\")]"));


    public IWebElement LoginBtn => Helper.FindElementWithWait(GetWebDriver, By.XPath("//a[@id=\"signin\"]"));
}