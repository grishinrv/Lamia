using System.Text.Json.Serialization;

namespace WebApi.Models;

public record Identifiers
{
    /// <summary>
    /// goodreads
    /// </summary>
    [JsonPropertyName("goodreads")]
    public List<string> GoodReads { get; init; }
    /// <summary>
    /// librarything
    /// </summary>
    [JsonPropertyName("librarything")]
    public List<string> LibraryThing { get; init; }
}