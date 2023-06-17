using OpenQA.Selenium;
using Utilities.Utilities;

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
        UiHelper.ClearAndSendKeys(_map.PositionField, position);
    }

    public void EnterName(string name)
    {
        UiHelper.ClearAndSendKeys(_map.NameField, name);
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

    public override IWebElement UniqueElement => UiHelper.FindElementWithWait(GetWebDriver,
        By.XPath("//div[@class=\"col-lg-12\"]/h1[contains(text(),\"Profile\")]"));

    public IWebElement PositionField =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"inputRole\"]"));

    public IWebElement UpdateSettingsBtn =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//button[@data-qase-test=\"update-settings\"]"));

    public IWebElement NameField => UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"inputName\"]"));
}