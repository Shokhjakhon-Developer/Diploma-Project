using NUnit.Framework;
using Selenium_Wrapper.Driver_Wrapper.Browser;
using Selenium_Wrapper.Driver_Wrapper.Browser_settings;

namespace Tests.Tests_d;

public abstract class BaseTest
{
    protected readonly Browser Browser = BrowserService.Browser;

    [SetUp]
    public void SetUp()
    {
        Browser.GoToUrl("https://qase.io/");
    }

    [TearDown]
    public void TearDown()
    {
        Browser.Quit();
    }
}