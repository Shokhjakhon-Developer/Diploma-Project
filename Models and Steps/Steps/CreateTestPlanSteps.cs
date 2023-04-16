using Models_and_Steps.Data;
using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class CreateTestPlanSteps : BaseSteps
{
    private readonly TestPlansPage _testPlansPage;
    private readonly TestPlanModel _model = TestPlanModelFactory.Model1;

    
    public  CreateTestPlanSteps(IWebDriver driver):base(driver)
    {
        _testPlansPage = new TestPlansPage("TestPlansPage",driver);
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

    public void EnterTitleAndDescription()
    {
        _testPlansPage.EnterTitle(_model.Title);
        _testPlansPage.EnterDescription(_model.Description);
        
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

    public bool IsPlanCreated()
    {
        var actual = _testPlansPage.GetPlanTitle();
        var expected = _model.Title;
        return actual.Equals(expected);
    }

    public void CleanUp()
    {
        _testPlansPage.ClickOnDropDown();
        _testPlansPage.ClickOnDeleteButton();
        _testPlansPage.ClickOnDeletePlanButton();
    }

    public bool IsCleanedUp()
    {
        return _testPlansPage.GetNoPlansLabelText();
    }
}