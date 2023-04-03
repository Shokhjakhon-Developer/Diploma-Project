using OpenQA.Selenium;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Pages;

public class MainPage : BasePage
{
    private readonly MainPageMap _map;

    public MainPage(string name) : base(name)
    {
        _map = new MainPageMap();
        UniqueElement = _map.UniqueElement;
    }

    public void ClickLoginButton()
    {
        var loginBtn = _map.LoginBtn;
        loginBtn.Click();
    }
}

internal class MainPageMap : BaseMap
{
    public MainPageMap()
    {
        UniqueElement = new Button("UniqueElement", By.XPath("//h1[contains(@class,\"text-white\")]"));
    }

    public readonly Button LoginBtn = new("LoginButton", By.XPath("//a[@id=\"signin\"]"));
}