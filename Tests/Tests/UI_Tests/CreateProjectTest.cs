using Models_and_Steps.Data;
using Models_and_Steps.Models;
using Models_and_Steps.Steps;
using NUnit.Framework;

namespace Tests.Tests.UI_Tests;

public class CreateProjectTest : BaseTest
{
    private ProjectCreationSteps _projectCreationSteps;
    private ProjectModel _projectModel;

    [SetUp]
    public void TestSetUp()
    {
        _projectCreationSteps = new ProjectCreationSteps(Driver);
        _projectModel = ProjectModelFactory.Model1;
    }

    [Test]
    public void TestCreateProject()
    {
        _projectCreationSteps.CreateProject(_projectModel);

        var actualModel = _projectCreationSteps.GetActualProject();

        Assert.That(actualModel, Is.EqualTo(_projectModel), "Actual model was not the same as expected one.");
    }

    [TearDown]
    public void TestCleanUp()
    {
        _projectCreationSteps.CleanUp(_projectModel);
    }
}