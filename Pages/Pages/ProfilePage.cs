using OpenQA.Selenium;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Pages;

public class ProfilePage : BasePage
{
    private readonly ProfilePageMap _map;

    public ProfilePage(string name) : base(name)
    {
        _map = new ProfilePageMap();
        UniqueElement = _map.UniqueElement;
    }

    public void EnterPosition(string position)
    {
        _map.PositionField.ClearAndEnterText(position);
    }

    public string GetPosition()
    {
        var position = _map.PositionField.GetValue();
        return position;
    }

    public void ClickOnUpdateSettings()
    {
        _map.UpdateSettingsBtn.Click();
    }
}

internal class ProfilePageMap : BaseMap
{
    public ProfilePageMap()
    {
        UniqueElement = new Label("ProfileHeader",
            By.XPath("//div[@class=\"col-lg-12\"]/h1[contains(text(),\"Profile\")]"));
    }

    public readonly TextInputField PositionField =
        new("PositionField", By.XPath("//input[@id=\"inputRole\"]"));

    public readonly Button UpdateSettingsBtn =
        new("UpdateSettingsButton", By.XPath("//button[@data-qase-test=\"update-settings\"]"));
}