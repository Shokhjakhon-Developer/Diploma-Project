using Allure.Net.Commons;
using Models_and_Steps.Data;
using Models_and_Steps.Models;
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
        TestPlanModel model = TestPlanModelFactory.Model1;

        _createTestPlanSteps.ClickOnTestPlans();
        _createTestPlanSteps.CreateTestPlans();
        _createTestPlanSteps.EnterTitleAndDescription(model);
        _createTestPlanSteps.AddCase();
        _createTestPlanSteps.AddAuthorizationTest();
        _createTestPlanSteps.CreatePlan();
        
        var actualTitle = _createTestPlanSteps.GetActualTitle();
        var actualDescription = _createTestPlanSteps.GetActualDescription();
        
        Assert.That(actualTitle, Is.EqualTo(model.Title), "Test plan title is not matched.");
        Assert.That(actualDescription, Is.EqualTo(model.Description), "Test plan description is not matched.");
    }

    [TearDown]
    public void TestCleanUp()
    {
        _createTestPlanSteps.CleanUp();
    }
}