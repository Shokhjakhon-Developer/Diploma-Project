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
        var addressField = _map.EmailField;
        addressField.EnterText(address);
    }

    public void EnterPassword(string password)
    {
        var passwordField = _map.PasswordField;
        passwordField.EnterText(password);
    }

    public void ClickLogin()
    {
        var loginBtn = _map.Login;
        loginBtn.Click();
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