using Models_and_Steps.Data;
using Models_and_Steps.Models;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class CreateDefectSteps : BaseSteps
{
    private readonly DefectsPage _defectsPage;
    private readonly DefectModel _model = DefectModelFactory.Model;

    public CreateDefectSteps()
    {
        _defectsPage = new DefectsPage("DefectsPage");
    }

    public void ClickOnDefects()
    {
        ProjectsPage.ClickOnDemoProjects();
        ProjectsPage.ClickOnDefects();
    }

    public bool AreWeOnDefectsPage()
    {
        return _defectsPage.IsPageOpened();
    }

    public CreateDefectSteps CreateDefect()
    {
        _defectsPage.ClickOnCreateDefect();
        return this;
    }

    public CreateDefectSteps EnterTitleAndResult()
    {
        _defectsPage.EnterTitle(_model.DefectTitle);
        _defectsPage.EnterActualResult(_model.ActualResult);
        return this;
    }

    public CreateDefectSteps ConfirmCreatingDefect()
    {
        _defectsPage.CreateDefect();
        return this;
    }

    public bool IsDefectCreated()
    {
        var actual = _defectsPage.GetDefectTitle();
        var expected = _model.DefectTitle;
        return actual.Equals(expected);
    }

    public void CleanUp()
    {
        _defectsPage.ClickOnDropDown();
        _defectsPage.ClickOnDeleteOption();
        _defectsPage.ConfirmDeletion();
    }

    public bool IsCleanedUp()
    {
        return _defectsPage.IsNoDefectDisplayed();
    }
}