using OpenQA.Selenium;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Pages;

public class TestPlansPage : BasePage
{
    private readonly TestPlanPageMap _map;

    public TestPlansPage(string name) : base(name)
    {
        _map = new TestPlanPageMap();
        UniqueElement = _map.UniqueElement;
    }

    public void CreateTestPlan()
    {
        _map.CreatePlan.Click();
    }

    public void EnterTitle(string title)
    {
        _map.TitleField.EnterText(title);
    }

    public void EnterDescription(string description)
    {
        _map.DescriptionField.EnterText(description);
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
        return _map.PlanTitle.GetText();
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
        return _map.NoPlans.IsDisplayed();
    }
}

internal class TestPlanPageMap : BaseMap
{
    public TestPlanPageMap()
    {
        UniqueElement = new Label("HeaderLabel", By.XPath("//h1[contains(text(),\"Test plans\")]"));
    }

    public readonly Button CreatePlan =
        new("CreatePlanButton", By.XPath("//h1/following-sibling::div/a[@id=\"createButton\"]"));

    public readonly TextInputField TitleField = new("TitleField", By.XPath("//input[@id=\"title\"]"));

    public readonly TextInputField DescriptionField =
        new("DescriptionField", By.XPath("//p[contains(@data-placeholder,\"Full\")]"));

    public readonly Button AddCases = new("AddCasesButton", By.XPath("//button[@id=\"edit-plan-add-cases-button\"]"));

    public readonly Label AuthorizationTest = new("AuthorizationLabel",
        By.XPath("//div[@id=\"suite-1-checkbox\"]"));

    public readonly Button DoneBtn = new("DoneButton", By.XPath("//span[contains(text(),\"Done\")]"));

    public readonly Button CreatePlanButton = new("CreatePlan", By.XPath("//button[@id=\"save-plan\"]"));

    public readonly Label PlanTitle = new("PlanTitleLabel", By.XPath("//a[@class=\"defect-title\"]"));

    public readonly Label DropDown = new("DropDownLabel", By.XPath("//td/button"));

    public readonly Button Delete = new("DeleteButton", By.XPath("//li[contains(text(),\"Delete\")]"));

    public readonly Button DeletePlan = new("DeletePlanButton", By.XPath("//span[contains(text(),\"Delete plan\")]"));

    public readonly Label NoPlans = new("NoPlansLabel", By.XPath("//div[contains(text(),\"Looks like\")]"));
}