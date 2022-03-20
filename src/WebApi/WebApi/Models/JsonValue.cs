namespace WebApi.Models;

public record JsonValue
{
    /// <summary>
    /// type
    /// </summary>
    public string Type { get; init; }

    /// <summary>
    /// value
    /// </summary>
    public string Value { get; init; }
}