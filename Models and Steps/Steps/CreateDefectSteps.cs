using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class CreateDefectSteps : BaseSteps
{
    private readonly DefectsPage _defectsPage;

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

    public void CreateDefect()
    {
        _defectsPage.ClickOnCreateDefect();
    }

    public void EnterTitleAndResult(DefectModel model)
    {
        _defectsPage.EnterTitle(model.DefectTitle);
        _defectsPage.EnterActualResult(model.ActualResult);
    }

    public void ConfirmCreatingDefect()
    {
        _defectsPage.CreateDefect();
    }

    public string GetActualTitle()
    {
        var actualTitle = _defectsPage.GetDefectTitle();
        return actualTitle;
    }

    public string GetActualDescription()
    {
        _defectsPage.ClickOnDefectTitle();
        var actualTitle = _defectsPage.GetActualDescription().Text;
        return actualTitle;
    }

    public void CleanUp()
    {
        ProjectsPage.ClickOnDefects();
        _defectsPage.ClickOnDropDown();
        _defectsPage.ClickOnDeleteOption();
        _defectsPage.ConfirmDeletion();
    }
}