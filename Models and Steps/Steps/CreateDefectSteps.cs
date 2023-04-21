using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class CreateDefectSteps : BaseSteps
{
    private readonly DefectsPage _defectsPage;
    private readonly ProjectsPage _projectsPage;

    public CreateDefectSteps(IWebDriver driver) : base(driver)
    {
        _defectsPage = new DefectsPage("DefectsPage", driver);
        _projectsPage = new ProjectsPage("Projects page", driver);
    }


    public void ClickOnDefects()
    {
        _projectsPage.ClickOnDefects();
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
    
}