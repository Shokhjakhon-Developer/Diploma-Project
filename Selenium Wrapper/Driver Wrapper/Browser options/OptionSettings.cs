using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Wrapper.Driver_Wrapper.Browser_options;

public abstract class OptionSettings
{
    public abstract DriverOptions DriverOption { get; }
}