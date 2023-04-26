using System.Text.Json.Serialization;

namespace API_models.Models;

public class AProjectModel : IModel
{
    [JsonPropertyName("title")] public string Title { get; set; }

    [JsonPropertyName("code")] public string Code { get; set; }

    public override bool Equals(object? obj)
    {
        var other = obj as AProjectModel;
        return LEquals(other);
    }

    protected bool LEquals(AProjectModel other)
    {
        return Title == other.Title && Code.ToUpper() == other.Code.ToUpper();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, Code);
    }

    public override string ToString()
    {
        return $"Title: {Title}, Code: {Code}";
    }
}