using OpenQA.Selenium;
using Utilities.Utilities;

namespace Pages.Pages;

public class ProjectsPage : BasePage
{
    private readonly ProjectsPageMap _map;

    public ProjectsPage(string name, IWebDriver driver) : base(name, driver)
    {
        _map = new ProjectsPageMap(driver);
    }

    public void ClickOnDeleteOption(string projectName)
    {
        _map.DeleteOption(projectName).Click();
    }

    public void ConfirmDeletion()
    {
        _map.ConfirmDeletion.Click();
    }

    public void ClickOnDropDown(string projectName)
    {
        _map.ProjectSpecificDropDown(projectName).Click();
    }

    public void ClickOnDemoProjects()
    {
        _map.DemoProjects.Click();
    }

    public void ClickOnTestRuns()
    {
        _map.TestRuns.Click();
    }

    public void ClickOnTestPlans()
    {
        _map.TestPlans.Click();
    }

    public void ClickOnDefects()
    {
        _map.Defects.Click();
    }

    public void CreateNewProject()
    {
        _map.CreateNewProjectBtn.Click();
    }

    public void EnterProjectName(string name)
    {
        _map.ProjectNameField.SendKeys(name);
    }

    public void EnterProjectCode(string code)
    {
        UiHelper.ClearAndSendKeys(_map.ProjectCodeField, code);
    }

    public void CreateProject()
    {
        _map.CreateProjectBtn.Click();
    }

    public string GetProjectNameText()
    {
        return _map.ProjectNameLabel.Text;
    }

    public void GoBackToProjects()
    {
        _map.GoBackToProject.Click();
    }
    public string GetProjectCodeText()
    {
        return _map.ProjectCodeLabel().Text;
    }

    protected override IWebElement UniqueElement => _map.UniqueElement;
}

internal class ProjectsPageMap : BaseMap
{
    public ProjectsPageMap(IWebDriver driver) : base(driver)
    {
    }

    public override IWebElement UniqueElement =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//div[@class=\"col-lg-12\"]/h1"));

    public IWebElement DemoProjects =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//a[contains(text(),\"Demo Project\")]"));

    public IWebElement TestRuns =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Test Runs\")]"));

    public IWebElement TestPlans =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Test Plans\")]"));

    public IWebElement Defects =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Defects\")]"));

    public IWebElement CreateNewProjectBtn =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//button[@id=\"createButton\"]"));

    public IWebElement ProjectNameField =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"project-name\"]"));

    public IWebElement ProjectCodeField =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"project-code\"]"));

    public IWebElement CreateProjectBtn =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//button[@type=\"submit\"]"));

    public IWebElement ProjectNameLabel =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//img/following-sibling::div"));

    public IWebElement ProjectCodeLabel() =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"suites\")]/parent::h1"));

    public IWebElement ProjectSpecificDropDown(string projectName) => UiHelper.FindElementWithWait(GetWebDriver,
        By.XPath($"//a[@href=\"/project/{projectName}\"]/following::a[@data-bs-toggle=\"dropdown\"]"));

    public IWebElement DeleteOption(string projectName) =>
        UiHelper.FindElementWithWait(GetWebDriver,
            By.XPath($"//a[@href=\"/project/{projectName}\"]//following::button[contains(text(),\"Delete\")]"));

    public IWebElement ConfirmDeletion =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Delete\")]"));

    public IWebElement GoBackToProject =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//a[@href=\"/projects\"]"));
}