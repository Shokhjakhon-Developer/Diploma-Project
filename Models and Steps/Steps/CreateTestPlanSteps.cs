using Models_and_Steps.Data;
using Models_and_Steps.Models;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class CreateTestPlanSteps : BaseSteps
{
    private readonly TestPlansPage _testPlansPage;
    private readonly TestPlanModel _model = TestPlanModelFactory.Model1;

    public CreateTestPlanSteps()
    {
        _testPlansPage = new TestPlansPage("TestPlansPage");
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

    public CreateTestPlanSteps CreateTestPlans()
    {
        _testPlansPage.CreateTestPlan();
        return this;
    }

    public CreateTestPlanSteps EnterTitleAndDescription()
    {
        _testPlansPage.EnterTitle(_model.Title);
        _testPlansPage.EnterDescription(_model.Description);
        return this;
    }

    public CreateTestPlanSteps AddCase()
    {
        _testPlansPage.ClickOnAddCasesButton();
        return this;
    }

    public CreateTestPlanSteps AddAuthorizationTest()
    {
        _testPlansPage.ClickOnAuthorizationTest();
        _testPlansPage.ClickOnDoneButton();
        return this;
    }


    public CreateTestPlanSteps CreatePlan()
    {
        _testPlansPage.ClickOnCreatePlanButton();
        return this;
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