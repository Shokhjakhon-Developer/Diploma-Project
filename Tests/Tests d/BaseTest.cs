using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using Selenium_Wrapper.Driver_Wrapper.Browser;
using Selenium_Wrapper.Driver_Wrapper.Browser_settings;
using Selenium_Wrapper.Utilities;

namespace Tests.Tests_d;

[AllureNUnit]
[AllureSuite("Acceptance Test")]
[TestFixture,Parallelizable]
public abstract class BaseTest
{
    private readonly Browser _browser = BrowserService.Browser;
    protected readonly AllureLifecycle Allure = AllureLifecycle.Instance;

    [SetUp]
    public void SetUp()
    {
        _browser.GoToUrl(AppConfig.GetProperty("driver","link"));
    }

    [TearDown]
    public void TearDown()
    {
        _browser.Quit();
    }
}