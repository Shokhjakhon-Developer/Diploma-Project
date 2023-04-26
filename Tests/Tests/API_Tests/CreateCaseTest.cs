using API_models.Data;
using API_Services.QaseApi.CaseService;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class CreateCaseTest : BaseTest
{
    [Test]
    [AllureDescription("Changing position in profile settings.")]
    [Category("API Test")]
    [AllureStory("Checking if we can create test case using api.")]
    public void TestCreateCase()
    {
        var caseService = new CaseService();
        caseService.CreateCase(ACaseModelFactory.Model, ProjectModel);
        var actualCaseViewModel = caseService.GetCaseByCode(ProjectModel);
        var expectedCaseViewModel = ViewModelFactory.ExpectedCaseViewModel;

        Assert.That(actualCaseViewModel, Is.EqualTo(expectedCaseViewModel), "Case may not have been created");
    }
}