using System.Text.Json.Serialization;

namespace API_models.Models;

public class ACaseModel : IModel
{
    [JsonPropertyName("title")] public string Title { get; set; }

    public override bool Equals(object? obj)
    {
        var other = obj as ACaseModel;
        return LEquals(other);
    }

    protected bool LEquals(ACaseModel other)
    {
        return Title == other.Title;
    }

    public override int GetHashCode()
    {
        return Title.GetHashCode();
    }

    public override string ToString()
    {
        return $"Title: {Title}";
    }
}