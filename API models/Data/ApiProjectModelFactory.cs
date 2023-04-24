using API_models.Models;
using Utilities.Utilities;

namespace API_models.Data;

public class ApiProjectModelFactory
{
    public static readonly ProjectModel Model = new()
    {
        Code = Helper.GetUniqueRandomStringWithLength(8),
        Title = Helper.GenUniqueRandomString()
    };
}