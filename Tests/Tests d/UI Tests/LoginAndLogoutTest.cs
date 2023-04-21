using Allure.Net.Commons;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests_d.UI_Tests;

[AllureFeature("Login and Logout Feature")]
public class LoginAndLogoutTest : BaseTest
{
    private LoginAndLogoutSteps _loginAndLogoutSteps;

    [SetUp]
    public void TestSetUp()
    {
        _loginAndLogoutSteps = new LoginAndLogoutSteps(Driver);
    }

    [Test]
    [Category("Acceptance Test")]
    [AllureDescription("Testing logging in and logging out features.")]
    [AllureStory("Checking if we can log in to the existed account and then log out.")]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestLoginAndLogout()
    {
        var areWeLoggedIn = _loginAndLogoutSteps.AreWeLoggedIn();
        Assert.That(areWeLoggedIn, Is.True, "Login failed");

        _loginAndLogoutSteps.Logout();
        var areWeLoggedOut = _loginAndLogoutSteps.AreWeLoggedOut();
        Assert.That(areWeLoggedOut, Is.True, "Logout failed");
    }
}