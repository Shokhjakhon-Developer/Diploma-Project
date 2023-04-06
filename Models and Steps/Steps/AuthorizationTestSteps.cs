using Pages.Pages;

namespace Models_and_Steps.Steps;

public class AuthorizationTestSteps : BaseSteps
{
    private readonly TestRunsPage _testRunsPage;

    public AuthorizationTestSteps()
    {
        _testRunsPage = new TestRunsPage("TestRunsPage");
    }

    public AuthorizationTestSteps ClickOnDemoProjects()
    {
        ProjectsPage.ClickOnDemoProjects();
        return this;
    }

    public AuthorizationTestSteps ClickOnTestRuns()
    {
        ProjectsPage.ClickOnTestRuns();
        return this;
    }

    public AuthorizationTestSteps ClickOnStartNewTestRuns()
    {
        _testRunsPage.ClickOnStartNewTestRuns();
        return this;
    }

    public AuthorizationTestSteps ClickOnAddTests()
    {
        _testRunsPage.ClickOnAddTests();
        return this;
    }

    public AuthorizationTestSteps AddAuthorizationTests()
    {
        _testRunsPage.ClickOnAuthorizationTests();
        _testRunsPage.ClickOnDoneButton();
        return this;
    }

    public AuthorizationTestSteps ClickOnStartRun()
    {
        _testRunsPage.ClickOnStartRunButton();
        return this;
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