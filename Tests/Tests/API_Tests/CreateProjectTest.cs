using API_models.Data;
using API_Services.QaseApi.ProjectService;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class CreateProjectTest : BaseTest
{
    [Test]
    public void TestCreateProject()
    {
        var projectService = new ProjectService();
        var actualProjectViewModel = projectService.GetProjectByCode(AProjectModelFactory.Model);
        var expectedProjectViewModel = ViewModelFactory.ExpectedProjectViewModel;

        Assert.That(actualProjectViewModel, Is.EqualTo(expectedProjectViewModel), "Project may not have been created");
    }
}