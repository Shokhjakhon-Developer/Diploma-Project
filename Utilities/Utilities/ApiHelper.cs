using Newtonsoft.Json.Linq;

namespace Utilities.Utilities;

public class ApiHelper
{
    public static dynamic GetJsonObject(string content)
    {
        dynamic jObject = JObject.Parse(content);
        return jObject;
    }
}