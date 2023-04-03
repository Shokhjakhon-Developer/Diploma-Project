using Models_and_Steps.Data;
using Pages.Component;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class LoginAndLogoutSteps
{
    private readonly LoginPage _loginPage;
    private readonly AccountBar _accountBar;

    public LoginAndLogoutSteps()
    {
        _loginPage = new LoginPage("Login page");
        _accountBar = new AccountBar("Account bar");
    }

    public void Login()
    {
        var user = UserLoginModelFactory.User1;
        _loginPage.EnterPassword(user.Password);
        _loginPage.EnterEmailAddress(user.Email);
        _loginPage.ClickLogin();
    }

    public void Logout()
    {
        _accountBar.ClickOnAccountBar();
        _accountBar.SignOut();
    }
}