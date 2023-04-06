using Models_and_Steps.Data;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public abstract class BaseSteps
{
    private readonly LoginPage _loginPage;
    private readonly MainPage _mainPage;
    protected readonly ProjectsPage ProjectsPage;


    public bool AreWeInLoginPage()
    {
        return _loginPage.IsPageOpened();
    }

    protected BaseSteps()
    {
        _loginPage = new LoginPage("LoginPage");
        _mainPage = new MainPage("MainPage");
        ProjectsPage = new ProjectsPage("ProjectsPage");
    }

    public void Login()
    {
        var user = UserLoginModelFactory.User1;
        _mainPage.ClickLoginButton();
        _loginPage.EnterPassword(user.Password);
        _loginPage.EnterEmailAddress(user.Email);
        _loginPage.ClickLogin();
    }

    public bool AreWeLoggedIn()
    {
        return ProjectsPage.IsPageOpened();
    }
}