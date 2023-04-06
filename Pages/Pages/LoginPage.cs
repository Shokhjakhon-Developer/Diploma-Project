using OpenQA.Selenium;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Pages;

public class LoginPage : BasePage
{
    private readonly LoginPageMap _map;

    public LoginPage(string name) : base(name)
    {
        _map = new LoginPageMap();
        UniqueElement = _map.UniqueElement;
    }

    public void EnterEmailAddress(string address)
    {
        _map.EmailField.EnterText(address);
    }

    public void EnterPassword(string password)
    {
        _map.PasswordField.EnterText(password);
    }

    public void ClickLogin()
    {
        _map.Login.Click();
    }
}

internal class LoginPageMap : BaseMap
{
    public LoginPageMap()
    {
        UniqueElement = new Button("UniqueElement", By.XPath("//a[@class=\"logo\"]"));
    }

    public readonly TextInputField EmailField = new("EmailField", By.XPath("//input[@id=\"inputEmail\"]"));

    public readonly TextInputField PasswordField = new("PasswordField", By.XPath("//input[@id=\"inputPassword\"]"));

    public readonly Button Login = new("SubmitLoginForm", By.XPath("//button[@id=\"btnLogin\"]"));
}