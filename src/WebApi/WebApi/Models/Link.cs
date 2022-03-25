using System.Text.Json.Serialization;

namespace WebApi.Models;

public record Link
{
    /// <summary>
    /// key
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; init; }
}