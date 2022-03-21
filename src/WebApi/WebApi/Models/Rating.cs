using System.Text.Json.Serialization;

namespace WebApi.Models;

public record Rating
{
    [JsonPropertyName("Source")]
    public string Source { get; init; }
    [JsonPropertyName("Value")]
    public string Value { get; init; }
}