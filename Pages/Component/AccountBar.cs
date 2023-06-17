using OpenQA.Selenium;
using Pages.Pages;
using Utilities.Utilities;

namespace Pages.Component;

public class AccountBar : BasePage
{
    private readonly AccountBarMap _map;

    public AccountBar(string name, IWebDriver driver) : base(name, driver)
    {
        _map = new AccountBarMap(driver);
    }

    public void ClickOnAccountBar()
    {
        var element = UniqueElement;
        element.Click();
    }

    public void SignOut()
    {
        var element = _map.SignOut;
        element.Click();
    }

    public void ClickOnProfile()
    {
        var element = _map.Profile;
        element.Click();
    }

    protected override IWebElement UniqueElement => _map.UniqueElement;
}

internal class AccountBarMap : BaseMap
{
    public AccountBarMap(IWebDriver driver) : base(driver)
    {
    }

    public override IWebElement UniqueElement =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//img"));


    public IWebElement SignOut => UiHelper.FindElementWithWait(GetWebDriver,
        By.XPath("//span[contains(text(),\"Sign out\")]"));

    public IWebElement Profile => GetWebDriver.FindElement(
        By.XPath("//span[contains(text(),\"Profile\")]"));
}