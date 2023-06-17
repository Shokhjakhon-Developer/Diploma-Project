using System.Text.Json.Serialization;

namespace API_models.Models;

public class ADefectModel : IModel
{
    [JsonPropertyName("title")] public string Title { get; set; }
    [JsonPropertyName("actual_result")] public string ActualResult { get; set; }
    [JsonPropertyName("severity")] public int Severity { get; set; }

    public override bool Equals(object? obj)
    {
        var other = obj as ADefectModel;
        return LEquals(other);
    }

    protected bool LEquals(ADefectModel other)
    {
        return Title == other.Title && ActualResult == other.ActualResult && Severity == other.Severity;
    }


    public override string ToString()
    {
        return $"Title: {Title}, Actual result: {ActualResult}, Severity: {Severity}";
    }
}