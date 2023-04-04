using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using Pages.Pages;

namespace Tests.Tests_d;

public class LoginAndLogoutTest : BaseTest
{
    [Test]
    [Obsolete("Obsolete")]
    [Category("Acceptance Test")]
    [AllureDescription("Testing logging in and logging out features.")]
    public void TestLoginAndLogout()
    {
        var mainPage = new MainPage("Main page");
        var loginPage = new LoginPage("Login page");
        var loginAndLogoutSteps = new LoginAndLogoutSteps();
        var projectsPage = new ProjectsPage("Projects Page");

        Allure.WrapInStep(() =>
        {
            var isMainPageOpened = mainPage.IsPageOpened();
            Assert.That(isMainPageOpened);
        }, "Checking if the main page is opened.");

        Allure.WrapInStep(() => { mainPage.ClickLoginButton(); }, "Clicking on login button.");

        Allure.WrapInStep(() =>
        {
            var isLoginPageOpened = loginPage.IsPageOpened();
            Assert.That(isLoginPageOpened);
        }, "Checking if the login page is opened.");


        Allure.WrapInStep(() => { loginAndLogoutSteps.Login(); }, "Performing login operation.");

        Allure.WrapInStep(() =>
        {
            var isProjectsPageOpened = projectsPage.IsPageOpened();
            Assert.That(isProjectsPageOpened);
        }, "Checking if we logged in.");

        Allure.WrapInStep(() => { loginAndLogoutSteps.Logout(); }, "Performing logout operation.");

        Allure.WrapInStep(() =>
        {
            var isLoginPageOpened = loginPage.IsPageOpened();
            Assert.That(isLoginPageOpened);
        }, "Checking if we logged out.");
    }
}