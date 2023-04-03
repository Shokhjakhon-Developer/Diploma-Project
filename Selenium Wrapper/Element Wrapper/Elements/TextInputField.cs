using OpenQA.Selenium;
using Selenium_Wrapper.Element_Wrapper.Additional_methods;
using Selenium_Wrapper.Utilities;

namespace Selenium_Wrapper.Element_Wrapper.Elements;

public class TextInputField : BaseElement,IInput
{
    public TextInputField(string name, By locator) : base(name, locator)
    {
    }

    public void EnterText(string text)
    {
        GetElement().SendKeys(text);
        LLogger.Instance.Info($"\"{text}\" was entered to {Name}.");
    }

    public void ClearAndEnterText(string text)
    {
        GetElement().Clear();
        EnterText(text);
        LLogger.Instance.Info($"Cleared then \"{text}\" was entered to {Name}.");
    }
}