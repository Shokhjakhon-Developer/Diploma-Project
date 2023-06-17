using System.Net;
using API_models.Data;
using API_models.Models;
using API_Services.QaseApi.CaseService;
using Models.Models;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class CreateCaseTest : BaseTest
{
    private Case _caseModel;
    private CaseService _caseService;

    [SetUp]
    public void SetUp()
    {
        _caseModel = new Case("Test Case");
        _caseService = new CaseService();
    }

    [Test]
    [AllureDescription("Changing position in profile settings.")]
    [Category("API Test")]
    [AllureStory("Checking if we can create test case using api.")]
    public void TestCreateCase()
    {
        var (statusCodeCreate, createCaseResponseContent) = _caseService.CreateCase(_caseModel, ProjectModel);
        Console.WriteLine(createCaseResponseContent);
        Assert.That(statusCodeCreate, Is.EqualTo(HttpStatusCode.OK), $"{createCaseResponseContent}");

        var (statusCodeGet, actualCaseModel, getCaseResponseContent) = _caseService.GetCaseByCode(ProjectModel);
        Assert.That(statusCodeGet, Is.EqualTo(HttpStatusCode.OK), $"{getCaseResponseContent}");
        Assert.That(actualCaseModel, Is.EqualTo(_caseModel), "Actual case model is not the same as expected one");
    }
}