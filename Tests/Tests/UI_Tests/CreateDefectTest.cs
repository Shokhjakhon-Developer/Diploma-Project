using Allure.Net.Commons;
using Models_and_Steps.Data;
using Models_and_Steps.Models;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests.UI_Tests;

[AllureFeature("Create a defect")]
public class CreateDefectTest : BaseTest
{
    private CreateDefectSteps _createDefectSteps;
    private ProjectCreationSteps _projectCreationSteps;
    private ProjectModel _projectModel;

    [SetUp]
    public void TestSetUp()
    {
        _createDefectSteps = new CreateDefectSteps(Driver);
        _projectModel = ProjectModelFactory.Model1;
        _projectCreationSteps = new ProjectCreationSteps(Driver);
        _projectCreationSteps.CreateProject(_projectModel);
    }

    [Test]
    [AllureDescription("Creating a new defect.")]
    [Category("Acceptance Test")]
    [AllureStory("User creates a new defect.")]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestCreateDefect()
    {
        DefectModel model = DefectModelFactory.Model;
        _createDefectSteps.ClickOnDefects();

        _createDefectSteps.CreateDefect();
        _createDefectSteps.EnterTitleAndResult(model);
        _createDefectSteps.ConfirmCreatingDefect();

        var actualTitle = _createDefectSteps.GetActualTitle();
        var actualDescription = _createDefectSteps.GetActualDescription();

        Assert.That(actualTitle, Is.EqualTo(model.DefectTitle), "Defect title is not matched");
        Assert.That(actualDescription, Is.EqualTo(model.ActualResult), "Defect description is not matched");
    }

    [TearDown]
    public void TestCleanUp()
    {
        _projectCreationSteps.CleanUp(_projectModel);
    }
}