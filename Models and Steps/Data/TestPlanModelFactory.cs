using Models_and_Steps.Models;

namespace Models_and_Steps.Data;

public static class TestPlanModelFactory
{
    public static readonly TestPlanModel Model1 = new()
    {
        Title = "Regression",
        Description = "Performing regular regression test."
    };
}