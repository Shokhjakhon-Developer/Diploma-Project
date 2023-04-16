using OpenQA.Selenium.Chrome;
using Selenium_Wrapper.Utilities;

namespace Selenium_Wrapper.Browser.Browser_options;

public class BrowserOptions
{
    public static ChromeOptions GetChromeOptions()
    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArgument(Helper.GetAppConfig().Driver.ChromeOptions.Disable_extensions);
        chromeOptions.AddArgument(Helper.GetAppConfig().Driver.ChromeOptions.Disable_dev_shm_usage);
        chromeOptions.AddArgument(Helper.GetAppConfig().Driver.ChromeOptions.No_sandbox);
        chromeOptions.AddArgument(Helper.GetAppConfig().Driver.ChromeOptions.Headless);
        chromeOptions.AddArgument(Helper.GetAppConfig().Driver.ChromeOptions.Window_size);
        return chromeOptions;
    }
}