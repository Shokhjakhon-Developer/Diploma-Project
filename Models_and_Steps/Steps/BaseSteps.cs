using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public abstract class BaseSteps
{
    private readonly LoginPage _loginPage;
    private readonly MainPage _mainPage;
    protected readonly ProjectsPage ProjectsPage;


    public bool AreWeLoggedOut()
    {
        return _loginPage.IsPageOpened();
    }

    protected BaseSteps(IWebDriver driver)
    {
        _loginPage = new LoginPage("LoginPage", driver);
        _mainPage = new MainPage("MainPage",driver);
        ProjectsPage = new ProjectsPage("ProjectsPage",driver);
    }

    public void Login(UserLoginModel user)
    {
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