using Allure.Net.Commons;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Tests.Tests_d;

public class CreateTestPlansTest : BaseTest
{
    [Test]
    [Obsolete("Obsolete")]
    [AllureDescription("Creating a new test plan.")]
    [Category("Acceptance Test")]
    [AllureStory("User is creating a new test plan.")]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestCreatingTestPlans()
    {
        var createTestPlanSteps = new CreateTestPlanSteps();

        Allure.WrapInStep(() => { createTestPlanSteps.Login(); }, "Logging in to the website");

        Allure.WrapInStep(() => { Assert.That(createTestPlanSteps.AreWeLoggedIn()); },
            "Checking if we are logged in");

        Allure.WrapInStep(() => { createTestPlanSteps.ClickOnTestPlans(); }, "Clicking on Test plan from side menu");

        Allure.WrapInStep(() => { Assert.That(createTestPlanSteps.AreWeInTestPlansPage); },
            "Checking if we are in test plans page");

        Allure.WrapInStep(() =>
        {
            createTestPlanSteps.CreateTestPlans()
                .EnterTitleAndDescription()
                .AddCase()
                .AddAuthorizationTest()
                .CreatePlan();
        }, "Creating a new test plan");

        Allure.WrapInStep(() => { Assert.That(createTestPlanSteps.IsPlanCreated()); },
            "Checking if new test plan was created");

        Allure.WrapInStep(() => { createTestPlanSteps.CleanUp(); },
            "Performing deletion of new test plan");

        Allure.WrapInStep(() => { Assert.That(createTestPlanSteps.IsCleanedUp()); },
            "Checking if deletion was successful");
    }
}