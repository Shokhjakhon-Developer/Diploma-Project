using System.Text.Json.Serialization;

namespace API_models.Models;

public class CaseModel 
{
    [JsonPropertyName("title")] public string Title { get; set; }
}