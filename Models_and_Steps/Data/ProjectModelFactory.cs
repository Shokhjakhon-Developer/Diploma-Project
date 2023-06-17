using Models_and_Steps.Models;
using Utilities.Utilities;

namespace Models_and_Steps.Data;

public class ProjectModelFactory
{
    public static readonly ProjectModel Model1 = new()
    {
        ProjectName = Faker.GenUniqueRandomString(),
        ProjectCode = Faker.GetUniqueRandomStringWithLength(8)
    };
}