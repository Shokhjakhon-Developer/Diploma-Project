using API_models.Data;
using API_models.Models;
using API_Services.QaseApi.ProjectService;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

[AllureNUnit]
[AllureSuite("Acceptance Test")]
[TestFixture]
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