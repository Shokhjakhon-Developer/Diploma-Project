using OpenQA.Selenium;
using Pages.Pages;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Component;

public class AccountBar : BasePage
{
    private readonly Map _map;

    public AccountBar(string name) : base(name)
    {
        _map = new Map();
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

internal class Map : BaseMap
{
    public Map()
    {
        UniqueElement = new Label("AccountLabel", By.XPath("//span[@class=\"Eb2vGG\"]"));
    }

    public Label SignOut = new("SignOutLabel",
        By.XPath("//div[@class=\"QyooxO\"]/span[contains(text(),\"Sign out\")]"));
}