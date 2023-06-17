using OpenQA.Selenium.Chrome;
using Utilities.Utilities;

namespace Selenium_Wrapper.Browser.Browser_options;

public class BrowserOptions
{
    public static ChromeOptions GetChromeOptions()
    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArgument(UiHelper.GetAppConfig().Driver.ChromeOptions.Disable_extensions);
        chromeOptions.AddArgument(UiHelper.GetAppConfig().Driver.ChromeOptions.Disable_dev_shm_usage);
        chromeOptions.AddArgument(UiHelper.GetAppConfig().Driver.ChromeOptions.No_sandbox);
        chromeOptions.AddArgument(UiHelper.GetAppConfig().Driver.ChromeOptions.Headless);
        chromeOptions.AddArgument(UiHelper.GetAppConfig().Driver.ChromeOptions.Window_size);
        return chromeOptions;
    }
}