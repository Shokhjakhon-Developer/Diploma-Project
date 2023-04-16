using Allure.Net.Commons;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests_d;

[AllureFeature("Create a defect")]
public class CreatingDefectTest : BaseTest
{
    private CreateDefectSteps _createDefectSteps;

    [SetUp]
    public void TestSetUp()
    {
        _createDefectSteps = new CreateDefectSteps(Driver);
    }

    [Test]
    [AllureDescription("Creating a new defect.")]
    [Category("Acceptance Test")]
    [AllureStory("User creates a new defect.")]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestCreatingDefect()
    {
        _createDefectSteps.ClickOnDefects();

        _createDefectSteps.CreateDefect();
        _createDefectSteps.EnterTitleAndResult();
        _createDefectSteps.ConfirmCreatingDefect();
        Assert.That(_createDefectSteps.IsDefectCreated(), Is.True, "Defect is not created");
    }

    [TearDown]
    public void TestCleanUp()
    {
        _createDefectSteps.CleanUp();
    }
}