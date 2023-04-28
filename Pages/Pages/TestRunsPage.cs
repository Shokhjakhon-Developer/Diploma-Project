using OpenQA.Selenium;
using Utilities.Utilities;

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
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//div[@class=\"col-lg-12\"]/h1"));

    public IWebElement StartNewTestRuns => UiHelper.FindElementWithWait(GetWebDriver,
        By.XPath("//div[@class=\"d-flex mt-3\"]/button[contains(@class,\"Uzx\")]"));

    public IWebElement AuthorizationTest => UiHelper.FindElementWithWait(GetWebDriver,
        By.XPath("//div[@id=\"suite-1-checkbox\"]"));

    public IWebElement AddTests =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//button[contains(text(),\"Add/modify\")]"));

    public IWebElement DoneBtn =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Done\")]"));

    public IWebElement StartRunBtn =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Start a run\")]"));

    public IWebElement OpenWizardBtn =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//button[@id=\"open-wizard\"]"));

    public IWebElement DropDown =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//a[@class=\"btn btn-dropdown\"]"));

    public IWebElement Delete =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Delete\")]"));

    public IWebElement ConfirmDelete => UiHelper.FindElementWithWait(GetWebDriver,
        By.XPath("//span[@class=\"ZwgkIF\" and contains(text(),\"Delete\")]"));

    public IWebElement CleanUpConfirmation =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//div[contains(text(),\"Looks like\")]"));
}