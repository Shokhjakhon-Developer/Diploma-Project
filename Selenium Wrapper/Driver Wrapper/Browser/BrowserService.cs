﻿using Selenium_Wrapper.Driver_Wrapper.Browser_settings;
using Selenium_Wrapper.Driver_Wrapper.Browser_settings.Additional_methods;

namespace Selenium_Wrapper.Driver_Wrapper.Browser;

public static class BrowserService
{
    private static readonly ThreadLocal<IBrowser> BrowserContainer = new();

    private static readonly ThreadLocal<BrowserFactory> BrowserFactoryContainer = new();

    private static bool IsApplicationStarted() => BrowserContainer.IsValueCreated && BrowserContainer.Value.IsStarted;

    public static Browser_settings.Browser Browser => (Browser_settings.Browser)GetBrowser();

    public static bool IsBrowserStarted => IsApplicationStarted();

    private static IBrowser GetBrowser()
    {
        if (!IsApplicationStarted())
        {
            BrowserContainer.Value = BrowserFactory.GetBrowser;
        }

        return BrowserContainer.Value;
    }

    private static BrowserFactory BrowserFactory
    {
        get
        {
            if (!BrowserFactoryContainer.IsValueCreated)
            {
                SetDefaultFactory();
            }

            return BrowserFactoryContainer.Value;
        }
        set => BrowserFactoryContainer.Value = value;
    }

    private static void SetDefaultFactory()
    {
        BrowserFactory = new LocalBrowserFactory(BrowserProfile);
    }

    private static BrowserProfile BrowserProfile => new();
}