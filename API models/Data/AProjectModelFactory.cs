using API_models.Models;
using Utilities.Utilities;

namespace API_models.Data;

public class AProjectModelFactory
{
    public static readonly AProjectModel Model = new()
    {
        Code = Helper.GetUniqueRandomStringWithLength(8),
        Title = Helper.GenUniqueRandomString()
    };
}