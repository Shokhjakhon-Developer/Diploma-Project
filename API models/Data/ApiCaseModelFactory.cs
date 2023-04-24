using API_models.Models;
using Utilities.Utilities;

namespace API_models.Data;

public class ApiCaseModelFactory
{
    public static readonly CaseModel Model = new()
    {
        Title = Helper.GetUniqueRandomStringWithLength(8)
    };
}