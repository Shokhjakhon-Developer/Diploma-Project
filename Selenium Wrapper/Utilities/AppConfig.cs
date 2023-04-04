using System.Text.Json;

namespace Selenium_Wrapper.Utilities;

public class AppConfig
{
    private static readonly Json JsonSetUp =
        new(Directory.GetCurrentDirectory() + @"..\..\..\..\appSettings.json");

    public static string GetProperty(string property) => JsonSetUp.Root.GetProperty(property).ToString();

    public static string GetProperty(string property1, string property2) =>
        JsonSetUp.Root.GetProperty(property1).GetProperty(property2).ToString();

    public static string GetProperty(string property1, string property2, string property3) =>
        JsonSetUp.Root.GetProperty(property1).GetProperty(property2).GetProperty(property3).ToString();
}

internal class Json
{
    public JsonElement Root { get; }

    public Json(string path)
    {
        string jsonData = File.ReadAllText(path);
        JsonDocument jsonDocument = JsonDocument.Parse(jsonData);
        Root = jsonDocument.RootElement;
        LLogger.Instance.Info($"appSettings file path: {path}");
    }
}