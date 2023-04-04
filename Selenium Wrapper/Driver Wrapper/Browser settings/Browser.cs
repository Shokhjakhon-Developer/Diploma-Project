using OpenQA.Selenium;
using Selenium_Wrapper.Driver_Wrapper.Browser_settings.Additional_methods;
using Selenium_Wrapper.Utilities;

namespace Selenium_Wrapper.Driver_Wrapper.Browser_settings;

public class Browser : IBrowser
{
    public WebDriver WebDriver { get; }

    private SessionId SessionId { get; }

    public Browser(WebDriver webDriver)
    {
        WebDriver = webDriver;
        SessionId = webDriver.SessionId;
        MaximizeWindow();
        SetImplicitTime();
    }

    public void GoToUrl(Uri uri)
    {
        var link = uri.ToString();
        GoToUrl(link);
    }

    public void GoToUrl(string uri)
    {
        WebDriver.Navigate().GoToUrl(uri);
        LLogger.Instance.Info($"WebDriver with session id {SessionId} is started.");
        LLogger.Instance.Info($"Current link: {uri}");
    }

    public void Quit()
    {
        WebDriver.Quit();
        LLogger.Instance.Info($"WebDriver with session {SessionId} is finished.");
    }

    private void MaximizeWindow()
    {
        WebDriver.Manage().Window.Maximize();
    }

    private void SetImplicitTime()
    {
        WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    }

    public bool IsStarted => WebDriver.SessionId != null;
}