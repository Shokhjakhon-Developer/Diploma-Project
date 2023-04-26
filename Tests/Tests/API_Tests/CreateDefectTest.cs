using API_models.Data;
using API_Services.QaseApi.DefectService;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class CreateDefectTest : BaseTest
{
    [Test]
    public void TestCreateDefect()
    {
        var defectService = new DefectService();
        defectService.CreateDefect(ADefectModelFactory.Model, ProjectModel.Code);
        var actualDefectViewModel = defectService.GetDefectByCode(ProjectModel.Code);
        var expectedDefectViewModel = ViewModelFactory.ExpectedDefectViewModel;

        Assert.That(actualDefectViewModel, Is.EqualTo(expectedDefectViewModel), "Defect may not have been created");
    }
}