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
        Driver = new Browser().BrowserInit();
        new LoginAndLogoutSteps(Driver).Login();
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}