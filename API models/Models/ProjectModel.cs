using System.Text.Json.Serialization;

namespace API_models.Models;

public class ProjectModel 
{
    [JsonPropertyName("title")] public string Title { get; set; }

    [JsonPropertyName("code")] public string Code { get; set; }
}