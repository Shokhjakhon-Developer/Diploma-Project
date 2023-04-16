using OpenQA.Selenium;
using Selenium_Wrapper.Utilities;

namespace Pages.Pages;

public class TestRunsPage : BasePage
{
    private readonly TestRunsPageMap _map;

    public TestRunsPage(string name, IWebDriver driver) : base(name, driver)
    {
        _map = new TestRunsPageMap(driver);
    }

    public void ClickOnStartNewTestRuns()
    {
        _map.StartNewTestRuns.Click();
    }

    public void ClickOnAddTests()
    {
        _map.AddTests.Click();
    }

    public void ClickOnAuthorizationTests()
    {
        _map.AuthorizationTest.Click();
    }

    public void ClickOnDoneButton()
    {
        _map.DoneBtn.Click();
    }

    public void ClickOnStartRunButton()
    {
        _map.StartRunBtn.Click();
    }

    public bool IsButtonDisplayed()
    {
        return _map.OpenWizardBtn.Displayed;
    }

    public void ClickOnDropdown()
    {
        _map.DropDown.Click();
    }

    public void ClickOnDeleteOption()
    {
        _map.Delete.Click();
    }

    public void ClickOnConfirmDelete()
    {
        _map.ConfirmDelete.Click();
    }

    public bool IsCleanedUp()
    {
        return _map.CleanUpConfirmation.Displayed;
    }

    protected override IWebElement UniqueElement => _map.UniqueElement;
}

internal class TestRunsPageMap : BaseMap
{
    public TestRunsPageMap(IWebDriver driver) : base(driver)
    {
    }

    public override IWebElement UniqueElement =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//div[@class=\"col-lg-12\"]/h1"));

    public IWebElement StartNewTestRuns => Helper.FindElementWithWait(GetWebDriver,
        By.XPath("//div[@class=\"d-flex mt-3\"]/button[contains(@class,\"Uzx\")]"));

    public IWebElement AuthorizationTest => Helper.FindElementWithWait(GetWebDriver,
        By.XPath("//div[@id=\"suite-1-checkbox\"]"));

    public IWebElement AddTests =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//button[contains(text(),\"Add/modify\")]"));

    public IWebElement DoneBtn =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Done\")]"));

    public IWebElement StartRunBtn =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Start a run\")]"));

    public IWebElement OpenWizardBtn =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//button[@id=\"open-wizard\"]"));

    public IWebElement DropDown =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//a[@class=\"btn btn-dropdown\"]"));

    public IWebElement Delete =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Delete\")]"));

    public IWebElement ConfirmDelete => Helper.FindElementWithWait(GetWebDriver,
        By.XPath("//span[@class=\"ZwgkIF\" and contains(text(),\"Delete\")]"));

    public IWebElement CleanUpConfirmation =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//div[contains(text(),\"Looks like\")]"));
}