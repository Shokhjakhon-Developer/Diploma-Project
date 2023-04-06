using OpenQA.Selenium;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Pages;

public class TestRunsPage : BasePage
{
    private readonly TestRunsPageMap _map;

    public TestRunsPage(string name) : base(name)
    {
        _map = new TestRunsPageMap();
        UniqueElement = _map.UniqueElement;
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
        return _map.OpenWizardBtn.IsDisplayed();
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
        return _map.CleanUpConfirmation.IsDisplayed();
    }
}

internal class TestRunsPageMap : BaseMap
{
    public TestRunsPageMap()
    {
        UniqueElement = new Label("Header", By.XPath("//div[@class=\"col-lg-12\"]/h1"));
    }

    public readonly Button StartNewTestRuns = new("StartNewTestRunButton",
        By.XPath("//div[@class=\"d-flex mt-3\"]/button[contains(@class,\"Uzx\")]"));

    public readonly Label AuthorizationTest = new("AuthorizationLabel",
        By.XPath("//div[@id=\"suite-1-checkbox\"]"));

    public readonly Label AddTests =
        new("AddTestsButton", By.XPath("//button[contains(text(),\"Add/modify\")]"));

    public readonly Button DoneBtn = new("DoneButton", By.XPath("//span[contains(text(),\"Done\")]"));

    public readonly Button StartRunBtn = new("StartRunButton", By.XPath("//span[contains(text(),\"Start a run\")]"));

    public readonly Button OpenWizardBtn = new("OpenWizardButton", By.XPath("//button[@id=\"open-wizard\"]"));

    public readonly Label DropDown = new("DropDown", By.XPath("//a[@class=\"btn btn-dropdown\"]"));

    public readonly Button Delete = new("DeleteButton", By.XPath("//span[contains(text(),\"Delete\")]"));

    public readonly Button ConfirmDelete = new("ConfirmDeleteButton",
        By.XPath("//span[@class=\"ZwgkIF\" and contains(text(),\"Delete\")]"));

    public readonly Label CleanUpConfirmation =
        new Label("CleanUpConfirmationLabel", By.XPath("//div[contains(text(),\"Looks like\")]"));
}