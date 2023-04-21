using OpenQA.Selenium;
using Selenium_Wrapper.Utilities;

namespace Pages.Pages;

public class ProfilePage : BasePage
{
    private readonly ProfilePageMap _map;

    public ProfilePage(string name, IWebDriver driver) : base(name, driver)
    {
        _map = new ProfilePageMap(driver);
    }

    public void EnterPosition(string position)
    {
        Helper.ClearAndSendKeys(_map.PositionField, position);
    }

    public void EnterName(string name)
    {
        Helper.ClearAndSendKeys(_map.NameField, name);
    }

    public string GetPosition()
    {
        var position = _map.PositionField.GetAttribute("value");
        return position;
    }

    public string GetName()
    {
        var name = _map.NameField.GetAttribute("value");
        return name;
    }

    public void ClickOnUpdateSettings()
    {
        _map.UpdateSettingsBtn.Click();
    }

    protected override IWebElement UniqueElement => _map.UniqueElement;
}

internal class ProfilePageMap : BaseMap
{
    public ProfilePageMap(IWebDriver driver) : base(driver)
    {
    }

    public override IWebElement UniqueElement => Helper.FindElementWithWait(GetWebDriver,
        By.XPath("//div[@class=\"col-lg-12\"]/h1[contains(text(),\"Profile\")]"));

    public IWebElement PositionField =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"inputRole\"]"));

    public IWebElement UpdateSettingsBtn =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//button[@data-qase-test=\"update-settings\"]"));

    public IWebElement NameField => Helper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"inputName\"]"));
}