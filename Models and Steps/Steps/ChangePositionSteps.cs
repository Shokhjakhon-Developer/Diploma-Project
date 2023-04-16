using Models_and_Steps.Data;
using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Component;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class ChangePositionSteps : BaseSteps
{
    private readonly AccountBar _accountBar;
    private readonly ProfilePage _profilePage;
    private readonly UserProfileModel _profile = UserProfileModelFactory.UserProfile1;

    public ChangePositionSteps(IWebDriver driver) : base(driver)
    {
        _accountBar = new AccountBar("AccountBar",driver);
        _profilePage = new ProfilePage("ProfilePage",driver);
    }


    public void ChangePosition()
    {
        _accountBar.ClickOnAccountBar();
        _accountBar.ClickOnProfile();
        _profilePage.EnterPosition(_profile.Position);
        _profilePage.ClickOnUpdateSettings();
    }

    

    public bool IsPositionChanged()
    {
        var actualPosition = _profilePage.GetPosition();
        var expectedPosition = _profile.Position;
        return actualPosition.Equals(expectedPosition);
    }
}