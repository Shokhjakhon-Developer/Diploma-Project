using OpenQA.Selenium;
using Selenium_Wrapper.Utilities;

namespace Pages.Pages;

public class DefectsPage : BasePage
{
    private readonly DefectsPageMap _map;

    public DefectsPage(string name, IWebDriver driver) : base(name, driver)
    {
        _map = new DefectsPageMap(driver);
    }

    public void ClickOnDefectTitle()
    {
        _map.DefectTitle.Click();   
    }
    public void ClickOnCreateDefect()
    {
        _map.CreateDefect.Click();
    }

    public void EnterTitle(string title)
    {
        _map.TitleField.SendKeys(title);
    }

    public void EnterActualResult(string result)
    {
        _map.ActualResultField.SendKeys(result);
    }

    public void CreateDefect()
    {
        _map.ConfirmCreatingDefect.Click();
    }

    public string GetDefectTitle()
    {
        return _map.DefectTitle.Text;
    }
    
    public void ClickOnDropDown()
    {
        _map.DropDown.Click();
    }

    public void ClickOnDeleteOption()
    {
        _map.DeleteOption.Click();
    }

    public IWebElement GetActualDescription()
    {
        return _map.ActualDescription;
    }


    public void ConfirmDeletion()
    {
        _map.ConfirmDelete.Click();
    }

    public bool IsNoDefectDisplayed()
    {
        return _map.NoDefects.Displayed;
    }

    protected override IWebElement UniqueElement => _map.UniqueElement;
}

internal class DefectsPageMap : BaseMap
{
    public DefectsPageMap(IWebDriver driver) : base(driver)
    {
    }
    
    public IWebElement ActualDescription =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//div[@class=\"toastui-editor-contents\"]/p"));

    public override IWebElement UniqueElement =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//h1[contains(text(),\"Defects\")]"));


    public IWebElement CreateDefect =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//a[@class=\"btn btn-primary\"]"));

    public IWebElement TitleField => Helper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"title\"]"));

    public IWebElement ActualResultField =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//div[@contenteditable=\"true\"]/p"));

    public IWebElement ConfirmCreatingDefect =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//button[contains(text(),\"Create\")]"));

    public IWebElement DefectTitle =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//a[@class=\"defect-title\"]"));

    public IWebElement DropDown =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//a[@class=\"btn btn-dropdown\"]"));

    public IWebElement DeleteOption =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//a[contains(text(),\"Delete\")]"));

    public IWebElement ConfirmDelete =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//span[contains(text(),\"Delete\")]"));

    public IWebElement NoDefects =>
        Helper.FindElementWithWait(GetWebDriver, By.XPath("//div[contains(text(),\"Looks like\")]"));
}