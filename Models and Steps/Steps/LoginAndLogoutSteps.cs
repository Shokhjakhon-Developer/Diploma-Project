using OpenQA.Selenium;
using Pages.Component;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class LoginAndLogoutSteps : BaseSteps
{
    private readonly AccountBar _accountBar;
    private readonly MainPage _mainPage;

    public LoginAndLogoutSteps(IWebDriver driver):base(driver)
    {
        _accountBar = new AccountBar("Account bar",driver);
        _mainPage = new MainPage("MainPage",driver);
    }

    public bool AreWeInMainPage()
    {
        var isMainPageOpened = _mainPage.IsPageOpened();
        return isMainPageOpened;
    }


    public void Logout()
    {
        _accountBar.ClickOnAccountBar();
        _accountBar.SignOut();
    }
}