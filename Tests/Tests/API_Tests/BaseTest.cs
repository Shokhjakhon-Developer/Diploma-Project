using System.Net;
using API_models.Data;
using API_models.Models;
using API_Services.QaseApi.ProjectService;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

[AllureNUnit]
[AllureSuite("API Tests")]
public class BaseTest
{
    protected AProjectModel ProjectModel;
    protected ProjectService ProjectService;

    [SetUp]
    public void BeforeTest()
    {
        ProjectModel = new AProjectModelFactory().Model;
        ProjectService = new ProjectService();
        var (statusCodeCreateProject, createProjectResponseContent) = ProjectService.CreateProject(ProjectModel);
        Assert.That(statusCodeCreateProject, Is.EqualTo(HttpStatusCode.OK), $"{createProjectResponseContent}");
    }

    [TearDown]
    public void AfterTest()
    {
        ProjectService.DeleteProjectByCode(ProjectModel);
    }
}