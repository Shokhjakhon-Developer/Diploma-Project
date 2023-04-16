using Models_and_Steps.Models;
using Selenium_Wrapper.Utilities;

namespace Models_and_Steps.Data;

public static class TestPlanModelFactory
{
    public static readonly TestPlanModel Model1 = new()
    {
        Title = Helper.GenUniqueRandomString(),
        Description = Helper.GenUniqueRandomString()
    };
}