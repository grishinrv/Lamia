namespace WebApi.Models;

public record Identifiers
{
    /// <summary>
    /// goodreads
    /// </summary>
    public List<string> GoodReads { get; init; }
    /// <summary>
    /// librarything
    /// </summary>
    public List<string> LibraryThing { get; init; }
}