using Pages.Component;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class LoginAndLogoutSteps : BaseSteps
{
    private readonly AccountBar _accountBar;
    private readonly MainPage _mainPage;

    public LoginAndLogoutSteps()
    {
        _accountBar = new AccountBar("Account bar");
        _mainPage = new MainPage("MainPage");
    }

    public bool AreWeInMainPage()
    {
        var isMainPageOpened = _mainPage.IsPageOpened();
        return isMainPageOpened;
    }


    public void Logout()
    {
        _accountBar.ClickOnAccountBar();
        _accountBar.SignOut();
    }
}