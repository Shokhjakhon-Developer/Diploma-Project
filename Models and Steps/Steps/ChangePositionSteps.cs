using Models_and_Steps.Data;
using Models_and_Steps.Models;
using Pages.Component;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class ChangePositionSteps : BaseSteps
{
    private readonly AccountBar _accountBar;
    private readonly ProfilePage _profilePage;
    private readonly UserProfileModel _profile = UserProfileModelFactory.UserProfile1;

    public ChangePositionSteps()
    {
        _accountBar = new AccountBar("AccountBar");
        _profilePage = new ProfilePage("ProfilePage");
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