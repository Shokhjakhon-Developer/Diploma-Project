using Models_and_Steps.Models;
using Utilities.Utilities;

namespace Models_and_Steps.Data;

public abstract class UserProfileModelFactory
{
    public static readonly UserProfileModel UserProfile1 = new()
    {
        Name = Faker.GenUniqueRandomString(),
        Position = Faker.GenUniqueRandomString()
    };
}