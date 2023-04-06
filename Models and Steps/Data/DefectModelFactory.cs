using Models_and_Steps.Models;

namespace Models_and_Steps.Data;

public static class DefectModelFactory
{
    public static readonly DefectModel Model = new()
    {
        DefectTitle = "Performance",
        ActualResult = "70% less performance than expected"
    };
}