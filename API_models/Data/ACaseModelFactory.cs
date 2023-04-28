using API_models.Models;
using Utilities.Utilities;

namespace API_models.Data;

//A stands for Api
public class ACaseModelFactory
{
    public readonly ACaseModel Model = new()
    {
        Title = Faker.GetUniqueRandomStringWithLength(8)
    };
}