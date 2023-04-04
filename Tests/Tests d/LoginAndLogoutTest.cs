using Models_and_Steps.Steps;
using NUnit.Framework;
using Pages.Pages;

namespace Tests.Tests_d;

public class LoginAndLogoutTest : BaseTest
{
    [Test]
    public void TestLoginAndLogout()
    {
        var mainPage = new MainPage("Main page");
        var loginPage = new LoginPage("Login page");
        //var projectsPage = new ProjectsPage("Projects Page");
        var loginAndLogoutSteps = new LoginAndLogoutSteps();
        var isMainPageOpened = mainPage.IsPageOpened();
        Assert.That(isMainPageOpened);
        mainPage.ClickLoginButton();
        var isLoginPageOpened = loginPage.IsPageOpened();
        Assert.That(isLoginPageOpened);
        loginAndLogoutSteps.Login();
        Thread.Sleep(2000);
        loginAndLogoutSteps.Logout();
        Thread.Sleep(2000);
    }
}