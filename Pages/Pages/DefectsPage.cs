using OpenQA.Selenium;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Pages;

public class DefectsPage : BasePage
{
    private readonly DefectsPageMap _map;

    public DefectsPage(string name) : base(name)
    {
        _map = new DefectsPageMap();
        UniqueElement = _map.UniqueElement;
    }

    public void ClickOnCreateDefect()
    {
        _map.CreateDefect.Click();
    }

    public void EnterTitle(string title)
    {
        _map.TitleField.EnterText(title);
    }

    public void EnterActualResult(string result)
    {
        _map.ActualResultField.EnterText(result);
    }

    public void CreateDefect()
    {
        _map.ConfirmCreatingDefect.Click();
    }

    public string GetDefectTitle()
    {
        return _map.DefectTitle.GetText();
    }

    public void ClickOnDropDown()
    {
        _map.DropDown.Click();
    }

    public void ClickOnDeleteOption()
    {
        _map.DeleteOption.Click();
    }


    public void ConfirmDeletion()
    {
        _map.ConfirmDelete.Click();
    }

    public bool IsNoDefectDisplayed()
    {
        return _map.NoDefects.IsDisplayed();
    }
}

internal class DefectsPageMap : BaseMap
{
    public DefectsPageMap()
    {
        UniqueElement = new Label("HeaderLabel", By.XPath("//h1[contains(text(),\"Defects\")]"));
    }

    public readonly Button CreateDefect = new("CreateDefectButton", By.XPath("//a[@class=\"btn btn-primary\"]"));

    public readonly TextInputField TitleField = new("TitleField", By.XPath("//input[@id=\"title\"]"));

    public readonly TextInputField ActualResultField =
        new("ActualResultField", By.XPath("//div[@contenteditable=\"true\"]/p"));

    public readonly Button ConfirmCreatingDefect = new("ConfirmCreatingDefectButton",
        By.XPath("//button[contains(text(),\"Create\")]"));

    public readonly Label DefectTitle = new("DefectTitleLabel", By.XPath("//a[@class=\"defect-title\"]"));

    public readonly Label DropDown = new("DropDown", By.XPath("//a[@class=\"btn btn-dropdown\"]"));

    public readonly Button DeleteOption = new("DeleteButton", By.XPath("//a[contains(text(),\"Delete\")]"));

    public readonly Button ConfirmDelete = new("ConfirmDeleteButton", By.XPath("//span[contains(text(),\"Delete\")]"));

    public readonly Label NoDefects = new("NoPlansLabel", By.XPath("//div[contains(text(),\"Looks like\")]"));
}