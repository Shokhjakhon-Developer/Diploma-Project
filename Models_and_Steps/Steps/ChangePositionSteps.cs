using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Component;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class ChangePositionSteps : BaseSteps
{
    private readonly AccountBar _accountBar;
    private readonly ProfilePage _profilePage;

    public ChangePositionSteps(IWebDriver driver) : base(driver)
    {
        _accountBar = new AccountBar("AccountBar", driver);
        _profilePage = new ProfilePage("ProfilePage", driver);
    }


    public void ChangePositionAndName(UserProfileModel model)
    {
        _accountBar.ClickOnAccountBar();
        _accountBar.ClickOnProfile();
        _profilePage.EnterPosition(model.Position);
        _profilePage.EnterName(model.Name);
        _profilePage.ClickOnUpdateSettings();
    }


    public UserProfileModel GetActualModel()
    {
        var actualPosition = _profilePage.GetPosition();
        var actualName = _profilePage.GetName();
        var actualModel = new UserProfileModel
        {
            Name = actualName,
            Position = actualPosition
        };
        return actualModel;
    }
}