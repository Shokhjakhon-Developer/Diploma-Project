using Models_and_Steps.Data;
using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class CreateDefectSteps : BaseSteps
{
    private readonly DefectsPage _defectsPage;
    private readonly DefectModel _model = DefectModelFactory.Model;

    public CreateDefectSteps(IWebDriver driver) : base(driver)
    {
        _defectsPage = new DefectsPage("DefectsPage", driver);
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

    public void EnterTitleAndResult()
    {
        _defectsPage.EnterTitle(_model.DefectTitle);
        _defectsPage.EnterActualResult(_model.ActualResult);
    }

    public void ConfirmCreatingDefect()
    {
        _defectsPage.CreateDefect();
    }

    public bool IsDefectCreated()
    {
        var actualTitle = _defectsPage.GetDefectTitle();
        var expectedTitle = _model.DefectTitle;
        var result = actualTitle.Equals(expectedTitle);
        return result;
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