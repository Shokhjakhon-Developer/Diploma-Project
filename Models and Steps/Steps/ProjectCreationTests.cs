using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class ProjectCreationSteps : BaseSteps
{
    private readonly ProjectsPage _projectsPage;

    public ProjectCreationSteps(IWebDriver driver) : base(driver)
    {
        _projectsPage = new ProjectsPage("Projects page", driver);
    }

    public void CreateProject(ProjectModel model)
    {
        _projectsPage.CreateNewProject();
        _projectsPage.EnterProjectName(model.ProjectName);
        _projectsPage.EnterProjectCode(model.ProjectCode);
        _projectsPage.CreateProject();
    }

    public void CleanUp(IWebDriver driver, ProjectModel model)
    {
        _projectsPage.GoBackToProjects();
        _projectsPage.ClickOnDropDown(model.ProjectCode.ToUpper());
        _projectsPage.ClickOnDeleteOption(model.ProjectCode.ToUpper());
        _projectsPage.ConfirmDeletion();
    }

    public ProjectModel GetActualProject()
    {
        var a = _projectsPage.GetProjectCodeText().Split(" ")[0].ToLower();
        var b = _projectsPage.GetProjectNameText().ToLower();
        var actualModel = new ProjectModel
        {
            ProjectCode = a,
            ProjectName = b
        };
        return actualModel;
    }
}