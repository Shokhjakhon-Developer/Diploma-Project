using API_models.Models;
using Utilities.Utilities;

namespace API_models.Data;

public class ADefectModelFactory
{
    public readonly ADefectModel Model = new()
    {
        Title = Faker.GetUniqueRandomStringWithLength(8),
        ActualResult = Faker.GetUniqueRandomStringWithLength(8),
        Severity = 0
    };
}