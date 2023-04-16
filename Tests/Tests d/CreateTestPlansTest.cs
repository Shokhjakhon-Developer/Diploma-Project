using Allure.Net.Commons;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests_d;

[AllureFeature("Create a test plan")]
public class CreateTestPlansTest : BaseTest
{
    private CreateTestPlanSteps _createTestPlanSteps;

    [SetUp]
    public void TestSetUp()
    {
        _createTestPlanSteps = new CreateTestPlanSteps(Driver);
    }

    [Test]
    [AllureDescription("Creating a new test plan.")]
    [Category("Acceptance Test")]
    [AllureStory("User is creating a new test plan.")]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestCreatingTestPlans()
    {
        _createTestPlanSteps.ClickOnTestPlans();
        _createTestPlanSteps.CreateTestPlans();
        _createTestPlanSteps.EnterTitleAndDescription();
        _createTestPlanSteps.AddCase();
        _createTestPlanSteps.AddAuthorizationTest();
        _createTestPlanSteps.CreatePlan();

        Assert.That(_createTestPlanSteps.IsPlanCreated(), Is.True, "Test plan is not created.");
    }

    [TearDown]
    public void TestCleanUp()
    {
        _createTestPlanSteps.CleanUp();
    }
}