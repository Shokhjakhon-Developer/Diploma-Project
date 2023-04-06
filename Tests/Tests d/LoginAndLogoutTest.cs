using Allure.Net.Commons;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Tests.Tests_d;

[AllureFeature("Login and Logout Feature")]
public class LoginAndLogoutTest : BaseTest
{
    [Test]
    [Obsolete("Obsolete")]
    [Category("Acceptance Test")]
    [AllureDescription("Testing logging in and logging out features.")]
    [AllureStory("Checking if we can log in to the existed account and then log out.")]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestLoginAndLogout()
    {
        var loginAndLogoutSteps = new LoginAndLogoutSteps();

        Allure.WrapInStep(() =>
        {
            var isMainPageOpened = loginAndLogoutSteps.AreWeInMainPage();
            Assert.That(isMainPageOpened);
        }, "Checking if the main page is opened.");


        Allure.WrapInStep(() => { loginAndLogoutSteps.Login(); }, "Performing login operation.");

        Allure.WrapInStep(() =>
        {
            var isProjectsPageOpened = loginAndLogoutSteps.AreWeLoggedIn();
            Assert.That(isProjectsPageOpened);
        }, "Checking if we logged in.");

        Allure.WrapInStep(() => { loginAndLogoutSteps.Logout(); }, "Performing logout operation.");

        Allure.WrapInStep(() =>
        {
            var isLoginPageOpened = loginAndLogoutSteps.AreWeInLoginPage();
            Assert.That(isLoginPageOpened);
        }, "Checking if we logged out.");
    }
}