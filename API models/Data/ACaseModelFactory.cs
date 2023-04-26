using API_models.Models;
using Utilities.Utilities;

namespace API_models.Data;

public class ACaseModelFactory
{
    public static readonly ACaseModel Model = new()
    {
        Title = Helper.GetUniqueRandomStringWithLength(8)
    };
}