using OpenQA.Selenium;
using Pages.Pages;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Component;

public class AccountBar : BasePage
{
    private readonly AccountBarMap _map;

    public AccountBar(string name) : base(name)
    {
        _map = new AccountBarMap();
    }

    public void ClickOnAccountBar()
    {
        var element = _map.UniqueElement;
        element.Click();
    }

    public void SignOut()
    {
        var element = _map.SignOut;
        element.Click();
    }
}

internal class AccountBarMap : BaseMap
{
    public AccountBarMap()
    {
        UniqueElement = new Label("AccountLabel", By.XPath("//span[@class=\"Eb2vGG\"]"));
    }

    public readonly Label SignOut = new("SignOutLabel",
        By.XPath("//div[@class=\"QyooxO\"]/span[contains(text(),\"Sign out\")]"));

    public readonly Label Profile = new("ProfileLabel",
        By.XPath("//a[@class=\"QyooxO\"]/span[contains(text(),\"Profile\")]"));
}