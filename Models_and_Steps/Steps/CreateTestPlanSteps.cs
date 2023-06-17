using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class CreateTestPlanSteps : BaseSteps
{
    private readonly TestPlansPage _testPlansPage;


    public CreateTestPlanSteps(IWebDriver driver) : base(driver)
    {
        _testPlansPage = new TestPlansPage("TestPlansPage", driver);
    }

    public bool AreWeInTestPlansPage()
    {
        return _testPlansPage.IsPageOpened();
    }

    public void ClickOnTestPlans()
    {
        ProjectsPage.ClickOnDemoProjects();
        ProjectsPage.ClickOnTestPlans();
    }

    public void CreateTestPlans()
    {
        _testPlansPage.CreateTestPlan();
    }

    public void EnterTitleAndDescription(TestPlanModel model)
    {
        _testPlansPage.EnterTitle(model.Title);
        _testPlansPage.EnterDescription(model.Description);
    }

    public void AddCase()
    {
        _testPlansPage.ClickOnAddCasesButton();
    }

    public void AddAuthorizationTest()
    {
        _testPlansPage.ClickOnAuthorizationTest();
        _testPlansPage.ClickOnDoneButton();
    }


    public void CreatePlan()
    {
        _testPlansPage.ClickOnCreatePlanButton();
    }

    public string GetActualTitle()
    {
        var actualTitle = _testPlansPage.GetPlanTitle();
        return actualTitle;
    }

    public string GetActualDescription()
    {
        _testPlansPage.ClickOnTestPlan();
        var actualDescription = _testPlansPage.GetActualDescriptionLabel().Text;
        return actualDescription;
    }

    public void CleanUp()
    {
        ProjectsPage.ClickOnTestPlans();
        _testPlansPage.ClickOnDropDown();
        _testPlansPage.ClickOnDeleteButton();
        _testPlansPage.ClickOnDeletePlanButton();
    }
}