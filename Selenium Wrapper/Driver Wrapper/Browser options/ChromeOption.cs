using OpenQA.Selenium.Chrome;
using Selenium_Wrapper.Utilities;

namespace Selenium_Wrapper.Driver_Wrapper.Browser_options;

public class ChromeOption : OptionSettings
{
    public override ChromeOptions DriverOption
    {
        get
        {
            var options = new ChromeOptions();
            options.AddArgument(AppConfig.GetProperty("driver", "chromeOptions", "1"));
            options.AddArgument(AppConfig.GetProperty("driver", "chromeOptions", "2"));
            options.AddArgument(AppConfig.GetProperty("driver", "chromeOptions", "3"));
            return options;
        }
    }
}