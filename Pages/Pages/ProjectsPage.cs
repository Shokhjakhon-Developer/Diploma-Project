using OpenQA.Selenium;
using Selenium_Wrapper.Utilities;

namespace Pages.Pages;

public class ProjectsPage : BasePage
{
    private readonly ProjectsPageMap _map;

    public ProjectsPage(string name, IWebDriver driver) : base(name, driver)
    {
        _map = new ProjectsPageMap(driver);
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

    protected override IWebElement UniqueElement => _map.UniqueElement;
}

internal class ProjectsPageMap : BaseMap
{
    public ProjectsPageMap(IWebDriver driver) : base(driver)
    {
    }

    public override IWebElement UniqueElement =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//div[@class=\"col-lg-12\"]/h1"));

    public IWebElement DemoProjects =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//a[contains(text(),\"Demo Project\")]"));

    public IWebElement TestRuns =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Test Runs\")]"));

    public IWebElement TestPlans =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Test Plans\")]"));

    public IWebElement Defects =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Defects\")]"));
}