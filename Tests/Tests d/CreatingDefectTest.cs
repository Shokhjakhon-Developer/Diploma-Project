using Allure.Net.Commons;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Tests.Tests_d;

public class CreatingDefectTest : BaseTest
{
    [Test]
    [Obsolete("Obsolete")]
    [AllureDescription("Creating a new defect.")]
    [Category("Acceptance Test")]
    [AllureStory("User creates a new defect.")]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestCreatingDefect()
    {
        var createDefectSteps = new CreateDefectSteps();

        Allure.WrapInStep(() => { createDefectSteps.Login(); }, "Logging in to the website");

        Allure.WrapInStep(() => { Assert.That(createDefectSteps.AreWeLoggedIn()); },
            "Checking if we are logged in");

        Allure.WrapInStep(() => { createDefectSteps.ClickOnDefects(); }, "Clicking of defects from side menu");
        Allure.WrapInStep(() => { Assert.That(createDefectSteps.AreWeOnDefectsPage()); },
            "Checking if we are in defects page");

        Allure.WrapInStep(() =>
        {
            createDefectSteps.CreateDefect()
                .EnterTitleAndResult()
                .ConfirmCreatingDefect();
        }, "Creating a new defect");
        Allure.WrapInStep(() => { Assert.That(createDefectSteps.IsDefectCreated()); },
            "Checking if we created a new defect");

        Allure.WrapInStep(() => { createDefectSteps.CleanUp(); },
            "Performing deletion of new defect");

        Allure.WrapInStep(() => { Assert.That(createDefectSteps.IsCleanedUp()); },
            "Checking if deletion was successful");
    }
}