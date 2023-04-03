using OpenQA.Selenium.Chrome;

namespace Selenium_Wrapper.Driver_Wrapper.Browser_options;

public class ChromeOption : OptionSettings
{
    public override ChromeOptions DriverOption
    {
        get
        {
            var options = new ChromeOptions();

            return options;
        }
    }
}