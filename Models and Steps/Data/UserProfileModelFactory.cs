using Models_and_Steps.Models;

namespace Models_and_Steps.Data;

public abstract class UserProfileModelFactory
{
    public static readonly UserProfileModel UserProfile1 = new()
    {
        Name = "Shokhjakhon",
        Position = "AQA Engineer"
    };
}