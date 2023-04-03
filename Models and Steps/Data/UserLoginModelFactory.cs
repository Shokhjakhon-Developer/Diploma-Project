using Models_and_Steps.Models;

namespace Models_and_Steps.Data;

public class UserLoginModelFactory
{
    public static readonly UserLoginModel User1 = new()
    {
        Email = "rs145609@gmail.com",
        Password = "qwerty123456789"
    };
}