using API_models.Data;
using API_models.Models;
using API_Services.QaseApi.ProjectService;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class BaseTest
{
    protected AProjectModel ProjectModel;
    private ProjectService _projectService;

    [SetUp]
    public void BeforeTest()
    {
        ProjectModel = AProjectModelFactory.Model;
        _projectService = new ProjectService();
        _projectService.CreateProject(ProjectModel);
    }

    [TearDown]
    public void AfterTest()
    {
        _projectService.DeleteProjectByCode(ProjectModel);
    }
}