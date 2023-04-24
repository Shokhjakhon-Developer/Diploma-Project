using System.Net;
using API_models.Data;
using API_models.Models;
using API_test_steps.Steps;
using NUnit.Framework;
using ProjectModel = API_models.Models.ProjectModel;

namespace Tests.Tests_d.API_tests;

public class CaseCreationTest
{
    private CaseCreationSteps _caseCreationSteps;
    private CaseModel _caseModel;
    private ProjectModel _projectModel;

    [SetUp]
    public void SetUp()
    {
        _caseModel = ApiCaseModelFactory.Model;
        _projectModel = ApiProjectModelFactory.Model;
        _caseCreationSteps = new CaseCreationSteps();
    }

    [Test]
    public void TestCaseCreation()
    {
        _caseCreationSteps.CreateCase(_projectModel, _caseModel);
        var responseStatusCode = _caseCreationSteps.GetCaseByCode(_projectModel);
        Console.WriteLine(responseStatusCode.Content);
        Assert.That(responseStatusCode.StatusCode, Is.EqualTo(HttpStatusCode.OK), $"{responseStatusCode.Content}");
    }

    [TearDown]
    public void TearDown()
    {
        _caseCreationSteps.CleanUp(_projectModel);
    }
}