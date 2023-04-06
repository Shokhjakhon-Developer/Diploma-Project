using Selenium_Wrapper.Driver_Wrapper.Browser_options;

namespace Selenium_Wrapper.Driver_Wrapper.Browser_settings;

public class BrowserProfile
{
    private readonly string _browserName = "chrome";

    public OptionSettings DriverSettings
    {
        get
        {
            switch (_browserName)
            {
                case "chrome":
                    return new ChromeOption();
                default:
                    throw new InvalidOperationException($"Driver settings for browser '{_browserName}' are not defined");
            }
        }
    }
}