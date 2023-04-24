using System.Text.Json.Serialization;

namespace API_models.Models;

public class DefectModel
{
    [JsonPropertyName("title")] public string Title { get; set; }
    [JsonPropertyName("actual_result")] public string ActualResult { get; set; }
    [JsonPropertyName("severity")] public int Severity { get; set; }
}