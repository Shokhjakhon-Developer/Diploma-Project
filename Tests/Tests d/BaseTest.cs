using Models_and_Steps.Data;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_Wrapper.Browser.Browser;


namespace Tests.Tests_d;

[AllureNUnit]
[AllureSuite("Acceptance Test")]
[TestFixture, Parallelizable]
public abstract class BaseTest
{
    protected IWebDriver Driver;

    [OneTimeSetUp]
    public void SetUp()
    {
        var user = UserLoginModelFactory.User1;
        Driver = new Browser().BrowserInit();
        new LoginAndLogoutSteps(Driver).Login(user);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}