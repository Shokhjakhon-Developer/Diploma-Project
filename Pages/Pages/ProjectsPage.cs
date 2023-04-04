using OpenQA.Selenium;
using Selenium_Wrapper.Element_Wrapper.Elements;

namespace Pages.Pages;

public class ProjectsPage : BasePage
{
    private readonly ProjectsPageMap _map;

    public ProjectsPage(string name) : base(name)
    {
        _map = new ProjectsPageMap();
        UniqueElement = _map.UniqueElement;
    }
}

internal class ProjectsPageMap : BaseMap
{
    public ProjectsPageMap()
    {
        UniqueElement = new Label("Header", By.XPath("//div[@class=\"col-lg-12\"]/h1"));
    }
}