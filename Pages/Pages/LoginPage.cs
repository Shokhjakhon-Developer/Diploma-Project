using OpenQA.Selenium;
using Utilities.Utilities;

namespace Pages.Pages;

public class LoginPage : BasePage
{
    private readonly LoginPageMap _map;


    public LoginPage(string name, IWebDriver driver) : base(name, driver)
    {
        _map = new LoginPageMap(driver);
    }

    public void EnterEmailAddress(string address)
    {
        _map.EmailField.SendKeys(address);
    }

    public void EnterPassword(string password)
    {
        _map.PasswordField.SendKeys(password);
    }

    public void ClickLogin()
    {
        _map.Login.Click();
    }

    protected override IWebElement UniqueElement => _map.UniqueElement;
}

internal class LoginPageMap : BaseMap
{
    public LoginPageMap(IWebDriver driver) : base(driver)
    {
    }

    public override IWebElement UniqueElement =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//a[@class=\"logo\"]"));


    public IWebElement EmailField => UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"inputEmail\"]"));

    public IWebElement PasswordField =>
        UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//input[@id=\"inputPassword\"]"));

    public IWebElement Login => UiHelper.FindElementWithWait(GetWebDriver, By.XPath("//button[@id=\"btnLogin\"]"));
}