using Selenium_Wrapper.Driver_Wrapper.Browser_options;

namespace Selenium_Wrapper.Driver_Wrapper.Browser_settings;

public class BrowserProfile
{
    public string BrowserName = "chrome";

    public OptionSettings DriverSettings
    {
        get
        {
            switch (BrowserName)
            {
                case "chrome":
                    return new ChromeOption();
                default:
                    throw new InvalidOperationException($"Driver settings for browser '{BrowserName}' are not defined");
            }
        }
    }
}