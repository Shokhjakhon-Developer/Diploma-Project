using API_models.Data;
using API_Services.QaseApi.DefectService;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class CreateDefectTest : BaseTest
{
    [Test]
    [AllureDescription("Create a defect using api.")]
    [Category("API Test")]
    [AllureStory("Checking if we can create a defect using api.")]
    public void TestCreateDefect()
    {
        var defectService = new DefectService();
        defectService.CreateDefect(ADefectModelFactory.Model, ProjectModel.Code);
        var actualDefectViewModel = defectService.GetDefectByCode(ProjectModel.Code);
        var expectedDefectViewModel = ViewModelFactory.ExpectedDefectViewModel;

        Assert.That(actualDefectViewModel, Is.EqualTo(expectedDefectViewModel), "Defect may not have been created");
    }
}