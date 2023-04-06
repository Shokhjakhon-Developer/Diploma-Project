using OpenQA.Selenium.Chrome;

namespace Selenium_Wrapper.Driver_Wrapper.Browser_options;

public class ChromeOption : OptionSettings
{
    public override ChromeOptions DriverOption
    {
        get
        {
            var options = new ChromeOptions();
            options.AddArgument("--disable-extensions");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--headless");
            options.AddArgument("window-size=1920,1080");
            
            return options;
        }
    }
}