using System.Net;
using API_models.Data;
using API_models.Models;
using API_test_steps.Steps;
using NUnit.Framework;

namespace Tests.Tests_d.API_tests;

public class ProjectCreationTest
{
    private ProjectModel _model;
    private ApiProjectCreationSteps _apiProjectCreationSteps;

    [SetUp]
    public void SetUp()
    {
        _model = ApiProjectModelFactory.Model;
        _apiProjectCreationSteps = new ApiProjectCreationSteps();
    }

    [Test]
    public void TestProjectCreation()
    {
        _apiProjectCreationSteps.CreateProject(_model);
        var projectValidation = _apiProjectCreationSteps.GetProjectByCode(_model);
        Assert.That(projectValidation.StatusCode, Is.EqualTo(HttpStatusCode.OK), $"{projectValidation.StatusCode}");
    }

    [TearDown]
    public void TearDown()
    {
        _apiProjectCreationSteps.DeleteProjectByCode(_model);
    }
}