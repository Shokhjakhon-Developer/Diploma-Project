using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Tests.Tests_d;

public class AuthorizationTest : BaseTest
{
    [Test]
    [Obsolete("Obsolete")]
    [AllureDescription("Starting a new manual authorization test.")]
    [Category("Acceptance Test")]
    [AllureStory("User start a new manual authorization test.")]
    [AllureSeverity]
    public void TestAuthorization()
    {
        var authorizationSteps = new AuthorizationTestSteps();

        Allure.WrapInStep(() => { authorizationSteps.Login(); }, "Logging in to the website");

        Allure.WrapInStep(() => { Assert.That(authorizationSteps.AreWeLoggedIn()); },
            "Checking if we are logged in");

        Allure.WrapInStep(() =>
        {
            authorizationSteps.ClickOnDemoProjects()
                .ClickOnTestRuns()
                .ClickOnStartNewTestRuns()
                .ClickOnAddTests()
                .AddAuthorizationTests()
                .ClickOnStartRun();
        }, "Creating a new manual authorization test");

        Allure.WrapInStep(() => { Assert.That(authorizationSteps.IsTestLaunched()); },
            "Checking if the test is launched");

        Allure.WrapInStep(() => { authorizationSteps.CleanUp(); },
            "Performing deletion of new authorization test");

        Allure.WrapInStep(() => { Assert.That(authorizationSteps.IsCleanedUp()); },
            "Checking if deletion was successful");
    }
}