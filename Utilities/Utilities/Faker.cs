namespace Utilities.Utilities;

public static class Faker
{
    public static string GenUniqueRandomString()
    {
        var guid = Guid.NewGuid();
        var randomStr = guid.ToString();
        return randomStr;
    }

    public static string GetUniqueRandomStringWithLength(int n)
    {
        var str = GenUniqueRandomString();
        var limitedStr = str[..n];
        return limitedStr;
    }
}