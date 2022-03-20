using System.Text.Json.Serialization;

namespace WebApi.Models;

public record JsonValue
{
    /// <summary>
    /// type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }

    /// <summary>
    /// value
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; init; }
}