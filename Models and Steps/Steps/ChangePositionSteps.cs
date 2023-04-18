using Models_and_Steps.Data;
using Models_and_Steps.Models;
using OpenQA.Selenium;
using Pages.Component;
using Pages.Pages;

namespace Models_and_Steps.Steps;

public class ChangePositionSteps : BaseSteps
{
    private readonly AccountBar _accountBar;
    private readonly ProfilePage _profilePage;

    public ChangePositionSteps(IWebDriver driver) : base(driver)
    {
        _accountBar = new AccountBar("AccountBar",driver);
        _profilePage = new ProfilePage("ProfilePage",driver);
    }


    public void ChangePosition(string position)
    {
        _accountBar.ClickOnAccountBar();
        _accountBar.ClickOnProfile();
        _profilePage.EnterPosition(position);
        _profilePage.ClickOnUpdateSettings();
    }

    

    public string GetActualPosition()
    {
        var actualPosition = _profilePage.GetPosition();
        return actualPosition;
    }
}