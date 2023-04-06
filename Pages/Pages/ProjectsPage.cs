using OpenQA.Selenium;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Pages;

public class ProjectsPage : BasePage
{
    private readonly ProjectsPageMap _map;

    public ProjectsPage(string name) : base(name)
    {
        _map = new ProjectsPageMap();
        UniqueElement = _map.UniqueElement;
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
}

internal class ProjectsPageMap : BaseMap
{
    public ProjectsPageMap()
    {
        UniqueElement = new Label("Header", By.XPath("//div[@class=\"col-lg-12\"]/h1"));
    }

    public readonly Label DemoProjects = new("DemoProjectsLabel", By.XPath("//a[contains(text(),\"Demo Project\")]"));

    public readonly Label TestRuns = new("TestRunsLabel", By.XPath("//span[contains(text(),\"Test Runs\")]"));

    public readonly Label TestPlans = new("TestPlansLabel", By.XPath("//span[contains(text(),\"Test Plans\")]"));

    public readonly Label Defects = new("DefectsLabel", By.XPath("//span[contains(text(),\"Defects\")]"));
}