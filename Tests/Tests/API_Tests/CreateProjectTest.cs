using API_models.Data;
using API_Services.QaseApi.ProjectService;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class CreateProjectTest : BaseTest
{
    [Test]
    [AllureDescription("Creating a project using api.")]
    [Category("API Test")]
    [AllureStory("Checking if we can create a project using api.")]
    public void TestCreateProject()
    {
        var projectService = new ProjectService();
        var actualProjectViewModel = projectService.GetProjectByCode(AProjectModelFactory.Model);
        var expectedProjectViewModel = ViewModelFactory.ExpectedProjectViewModel;

        Assert.That(actualProjectViewModel, Is.EqualTo(expectedProjectViewModel), "Project may not have been created");
    }
}