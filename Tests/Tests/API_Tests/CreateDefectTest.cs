using System.Net;
using API_models.Data;
using API_models.Models;
using API_Services.QaseApi.DefectService;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class CreateDefectTest : BaseTest
{
    private DefectService _defectService;
    private ADefectModel _defectModel;

    [SetUp]
    public void SetUp()
    {
        _defectService = new DefectService();
        _defectModel = new ADefectModelFactory().Model;
    }

    [Test]
    [AllureDescription("Create a defect using api.")]
    [Category("API Test")]
    [AllureStory("Checking if we can create a defect using api.")]
    public void TestCreateDefect()
    {
        var (statusCodeCreateProject, createDefectResponseContent) =
            _defectService.CreateDefect(_defectModel, ProjectModel.Code);
        Assert.That(statusCodeCreateProject, Is.EqualTo(HttpStatusCode.OK), $"{createDefectResponseContent}");

        var (statusCodeGetDefect, actualDefectModel, getDefectResponseContent) =
            _defectService.GetDefectByCode(ProjectModel.Code);
        Assert.That(statusCodeGetDefect, Is.EqualTo(HttpStatusCode.OK), $"{getDefectResponseContent}");
        Assert.That(actualDefectModel, Is.EqualTo(_defectModel), "Actual defect model is not the same as expected one");
    }
}