using API_models.Models;
using Utilities.Utilities;

namespace API_models.Data;

public class AProjectModelFactory
{
    public readonly AProjectModel Model = new()
    {
        Code = Faker.GetUniqueRandomStringWithLength(8),
        Title = Faker.GenUniqueRandomString()
    };
}