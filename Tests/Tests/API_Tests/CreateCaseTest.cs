using API_models.Data;
using API_Services.QaseApi.CaseService;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class CreateCaseTest : BaseTest
{
    [Test]
    public void TestCreateCase()
    {
        var caseService = new CaseService();
        caseService.CreateCase(ACaseModelFactory.Model, ProjectModel);
        var actualCaseViewModel = caseService.GetCaseByCode(ProjectModel);
        var expectedCaseViewModel = ViewModelFactory.ExpectedCaseViewModel;

        Assert.That(actualCaseViewModel, Is.EqualTo(expectedCaseViewModel), "Case may not have been created");
    }
}