using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests_d;

[AllureFeature("Create an authorization test")]
public class CreateAuthorizationTest : BaseTest
{
    private AuthorizationTestSteps _authorizationTestSteps;

    [SetUp]
    public void TestSetUp()
    {
        _authorizationTestSteps = new AuthorizationTestSteps(Driver);
    }

    [Test]
    [AllureDescription("Starting a new manual authorization test.")]
    [Category("Acceptance Test")]
    [AllureStory("User start a new manual authorization test.")]
    [AllureSeverity]
    public void TestAuthorization()
    {
        _authorizationTestSteps.ClickOnDemoProjects();
        _authorizationTestSteps.ClickOnTestRuns();
        _authorizationTestSteps.ClickOnStartNewTestRuns();
        _authorizationTestSteps.ClickOnAddTests();
        _authorizationTestSteps.AddAuthorizationTests();
        _authorizationTestSteps.ClickOnStartRun();

        Assert.That(_authorizationTestSteps.IsTestLaunched(), Is.True, "Test is not launched");
    }

    [TearDown]
    public void TestCleanUp()
    {
        _authorizationTestSteps.CleanUp();
    }
}