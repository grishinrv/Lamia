using System.Text.Json.Serialization;

namespace WebApi.Models;

public record Movie
{
    [JsonPropertyName("Title")]
    public string Title { get; init; }
    [JsonPropertyName("Year")]
    public string Year { get; init; }
    [JsonPropertyName("Rated")]
    public string Rated { get; init; }
    [JsonPropertyName("Released")]
    public DateOnly Released { get; init; }
    [JsonPropertyName("Runtime")]
    public string Runtime { get; init; }
    [JsonPropertyName("Plot")]
    public string Plot { get; init; }
    /// <summary>
    /// Genre
    /// </summary>
    [JsonPropertyName("Genre")]
    public string Genres { get; init; }
    [JsonPropertyName("Director")]
    public string Director { get; init; }
    /// <summary>
    /// Writer
    /// </summary>
    [JsonPropertyName("Writer")]
    public string Writers { get; init; }
    [JsonPropertyName("Actors")]
    public string Actors { get; init; }
    [JsonPropertyName("Language")]
    public string Languages { get; init; }
    /// <summary>
    /// Country
    /// </summary>
    [JsonPropertyName("Country")]
    public string Countries { get; init; }
    [JsonPropertyName("Awards")]
    public string Awards { get; init; }
    /// <summary>
    /// Poster image
    /// </summary>
    [JsonPropertyName("Poster")]
    public string Poster { get; init; }
    [JsonPropertyName("Ratings")]
    public List<Rating> Ratings { get; init; }
    /// <summary>
    /// Metascore
    /// </summary>
    [JsonPropertyName("Metascore")]
    public string MetaScore { get; init; }
    /// <summary>
    /// imdbRating
    /// </summary>
    [JsonPropertyName("imdbRating")]
    public string ImdbRating { get; init; }
    /// <summary>
    /// imdbVotes
    /// </summary>
    [JsonPropertyName("imdbVotes")]
    public string ImdbVotes { get; init; }
    /// <summary>
    /// imdbID
    /// </summary>
    [JsonPropertyName("imdbID")]
    public string ImdbId { get; init; }
    /// <summary>
    /// Type
    /// </summary>
    [JsonPropertyName("Type")]
    public string MovieType { get; init; }
    /// <summary>
    /// DVD
    /// </summary>
    [JsonPropertyName("DVD")]
    public DateOnly DvdReleaseDate { get; init; }
    [JsonPropertyName("BoxOffice")]
    public string BoxOffice { get; init; }
    [JsonPropertyName("Production")]
    public string Production { get; init; }
    [JsonPropertyName("Website")]
    public string Website { get; init; }
    [JsonPropertyName("Response")]
    public bool Response { get; init; }
}