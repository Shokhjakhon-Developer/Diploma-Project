using OpenQA.Selenium;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class AuthorizationTestSteps : BaseSteps
{
    private readonly TestRunsPage _testRunsPage;

    public AuthorizationTestSteps(IWebDriver driver) : base(driver)
    {
        _testRunsPage = new TestRunsPage("TestRunsPage", driver);
    }

    public void ClickOnDemoProjects()
    {
        ProjectsPage.ClickOnDemoProjects();
    }

    public void ClickOnTestRuns()
    {
        ProjectsPage.ClickOnTestRuns();
    }

    public void ClickOnStartNewTestRuns()
    {
        _testRunsPage.ClickOnStartNewTestRuns();
    }

    public void ClickOnAddTests()
    {
        _testRunsPage.ClickOnAddTests();
    }

    public void AddAuthorizationTests()
    {
        _testRunsPage.ClickOnAuthorizationTests();
        _testRunsPage.ClickOnDoneButton();
    }

    public void ClickOnStartRun()
    {
        _testRunsPage.ClickOnStartRunButton();
    }

    public bool IsTestLaunched()
    {
        return _testRunsPage.IsButtonDisplayed();
    }

    public void CleanUp()
    {
        ClickOnTestRuns();
        _testRunsPage.ClickOnDropdown();
        _testRunsPage.ClickOnDeleteOption();
        _testRunsPage.ClickOnConfirmDelete();
    }

    public bool IsCleanedUp()
    {
        return _testRunsPage.IsCleanedUp();
    }
}