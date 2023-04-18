using OpenQA.Selenium;
using Selenium_Wrapper.Utilities;

namespace Pages.Pages;

public class TestPlansPage : BasePage
{
    private readonly TestPlanPageMap _map;

    public TestPlansPage(string name, IWebDriver driver) : base(name, driver)
    {
        _map = new TestPlanPageMap(driver);
    }

    public void ClickOnTestPlan()
    {
        _map.PlanTitle.Click();
    }

    public void CreateTestPlan()
    {
        _map.CreatePlan.Click();
    }

    public void EnterTitle(string title)
    {
        _map.TitleField.SendKeys(title);
    }

    public void EnterDescription(string description)
    {
        _map.DescriptionField.SendKeys(description);
    }

    public void ClickOnAddCasesButton()
    {
        _map.AddCases.Click();
    }

    public void ClickOnAuthorizationTest()
    {
        _map.AuthorizationTest.Click();
    }

    public void ClickOnDoneButton()
    {
        _map.DoneBtn.Click();
    }

    public void ClickOnCreatePlanButton()
    {
        _map.CreatePlanButton.Click();
    }

    public string GetPlanTitle()
    {
        return _map.PlanTitle.Text;
    }

    public void ClickOnDropDown()
    {
        _map.DropDown.Click();
    }

    public void ClickOnDeleteButton()
    {
        _map.Delete.Click();
    }

    public void ClickOnDeletePlanButton()
    {
        _map.DeletePlan.Click();
    }

    public bool GetNoPlansLabelText()
    {
        return _map.NoPlans.Displayed;
    }

    public IWebElement GetActualDescriptionLabel()
    {
        return _map.ActualDescription;
    }

    protected override IWebElement UniqueElement => _map.UniqueElement;
}

internal class TestPlanPageMap : BaseMap
{
    public TestPlanPageMap(IWebDriver driver) : base(driver)
    {
    }

    public override IWebElement UniqueElement =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//h1[contains(text(),\"Test plans\")]"));


    public IWebElement CreatePlan =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//h1/following-sibling::div/a[@id=\"createButton\"]"));

    public IWebElement TitleField => Helper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"title\"]"));

    public IWebElement DescriptionField =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//p[contains(@data-placeholder,\"Full\")]"));

    public IWebElement AddCases =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//button[@id=\"edit-plan-add-cases-button\"]"));

    public IWebElement AuthorizationTest => Helper.FindElementWithWait(GetWebDriver,
        By.XPath("//div[@id=\"suite-1-checkbox\"]"));

    public IWebElement DoneBtn =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Done\")]"));

    public IWebElement CreatePlanButton =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//button[@id=\"save-plan\"]"));

    public IWebElement ActualDescription =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//div[@class=\"toastui-editor-contents\"]/p"));

    public IWebElement PlanTitle => Helper.FindElementWithWait(GetWebDriver, By.XPath("//a[@class=\"defect-title\"]"));
    public IWebElement DropDown => Helper.FindElementWithWait(GetWebDriver, By.XPath("//td/button"));

    public IWebElement Delete =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//li[contains(text(),\"Delete\")]"));

    public IWebElement DeletePlan =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Delete plan\")]"));

    public IWebElement NoPlans =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//div[contains(text(),\"Looks like\")]"));
}