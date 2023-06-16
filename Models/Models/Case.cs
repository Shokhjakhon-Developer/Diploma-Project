using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Models.Models;

public record Case(
    [JsonProperty("title")] string title,
    [JsonProperty("behaviour")] int Behaviour = 0,
    [JsonProperty("type")] int Type = 1,
    [JsonProperty("layer")] int Layer = 0,
    [JsonProperty("is_flaky")] int IsFlaky = 0,
    [JsonProperty("suite_id")] long? SuiteId = null,
    [JsonProperty("milestone_id")] long? MilestoneId = null,
    [JsonProperty("automation")] int Automation = 0,
    [JsonProperty("status")] int Status = 0,
    [JsonProperty("attachments")] string[]? Attachments = null,
    [JsonProperty("objects")] object? Steps = null,
    [JsonProperty("tags")] string[]? Tags = null,
    [JsonProperty("params")] object? Params = null,
    [JsonProperty("custom_field")] object? CustomFields = null,
    [JsonProperty("created_at")] DateTime? CreatedAt = null,
    [JsonProperty("updated_at")] DateTime? UpdatedAt = null,
    [JsonProperty("description")] string Description = "",
    [JsonProperty("preconditions")] string Preconditions = "",
    [JsonProperty("severity")] int Severity = 0,
    [JsonProperty("priority")] int Priority = 0);

// public record Case
// {
//     [JsonPropertyName("title")] public string? Title { get; init; }
//     [JsonPropertyName("description")] public string Description = "";
//     [JsonPropertyName("preconditions")] public string Preconditions = "";
//     [JsonPropertyName("severity")] public int Severity { get; init; }
//     [JsonPropertyName("priority")] public int Priority { get; init; }
//     [JsonPropertyName("behaviour")] public int Behaviour { get; init; }
//     [JsonPropertyName("type")] public int Type { get; init; }
//     [JsonPropertyName("layer")] public int Layer { get; init; }
//     [JsonPropertyName("is_flaky")] public int IsFlaky { get; init; }
//     [JsonPropertyName("suite_id")] public Int64 SuiteId { get; init; }
//     [JsonPropertyName("milestone_id")] public Int64 MilestoneId { get; init; }
//     [JsonPropertyName("automation")] public int Automation { get; init; }
//     [JsonPropertyName("status")] public int Status { get; init; }
//     [JsonPropertyName("attachments")] public string[]? Attachments { get; init; }
//     [JsonPropertyName("objects")] public object? Steps { get; init ; } 
//     [JsonPropertyName("tags")] public string[]? Tags { get; init; }
//     [JsonPropertyName("params")] public object? Params { get; init; }
//     [JsonPropertyName("custom_field")] public object? CustomFields { get; init; }
//     [JsonPropertyName("created_at")] public DateTime CreatedAt { get; init; }
//     [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; init; }
// }


// public record Case
// {
//     [JsonProperty("title")] public string Title { get; init; }
//     [JsonProperty("description")] public string Description = "";
//     [JsonProperty("preconditions")] public string Preconditions = "";
//     [JsonProperty("severity")] public int Severity  { get; init; }
//     [JsonProperty("priority")] public int Priority;
//     [JsonProperty("behaviour")] public int Behaviour;
//     [JsonProperty("type")] public int Type;
//     [JsonProperty("layer")] public int Layer;
//     [JsonProperty("is_flaky")] public int IsFlaky;
//     [JsonProperty("suite_id")] public Int64? SuiteId;
//     [JsonProperty("milestone_id")] public Int64? MilestoneId;
//     [JsonProperty("automation")] public int Automation;
//     [JsonProperty("status")] public int? Status;
//     [JsonProperty("attachments")] public string[]? Attachments;
//     [JsonProperty("objects")] public object? Steps;
//     [JsonProperty("tags")] public string[]? Tags;
//     [JsonProperty("params")] public object? Params;
//     [JsonProperty("custom_field")] public object? CustomFields;
//     [JsonProperty("created_at")] public DateTime? CreatedAt;
//     [JsonProperty("updated_at")] public DateTime? UpdatedAt;
// }