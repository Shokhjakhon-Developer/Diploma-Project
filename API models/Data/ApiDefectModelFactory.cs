using API_models.Models;
using Utilities.Utilities;

namespace API_models.Data;

public class ApiDefectModelFactory
{
    public static DefectModel Model = new()
    {
        Title = Helper.GetUniqueRandomStringWithLength(8),
        ActualResult = Helper.GetUniqueRandomStringWithLength(8),
        Severity = 1
    };
}