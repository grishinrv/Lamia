namespace WebApi.Models;

public record Movie
{
    public string Title { get; init; }
    public int Year { get; init; }
    public string Rated { get; init; }
    public string Released { get; init; }
    public string Runtime { get; init; }
    public string Plot { get; init; }
    /// <summary>
    /// Genre
    /// </summary>
    public List<string> Genres { get; init; }
    public string Director { get; init; }
    /// <summary>
    /// Writer
    /// </summary>
    public List<string> Writers { get; init; }
    public List<string> Actors { get; init; }
    public string Language { get; init; }
    /// <summary>
    /// Country
    /// </summary>
    public List<string> Countries { get; init; }
    public List<string> Awards { get; init; }
    /// <summary>
    /// Poster image
    /// </summary>
    public string Poster { get; init; }
    public List<string> Ratings { get; init; }
    /// <summary>
    /// Metascore
    /// </summary>
    public string MetaScore { get; init; }
    /// <summary>
    /// imdbRating
    /// </summary>
    public string ImdbRating { get; init; }
    /// <summary>
    /// imdbVotes
    /// </summary>
    public string ImdbVotes { get; init; }
    /// <summary>
    /// imdbID
    /// </summary>
    public string ImdbId { get; init; }
    /// <summary>
    /// Type
    /// </summary>
    public string MovieType { get; init; }
    /// <summary>
    /// DVD
    /// </summary>
    public string Dvd { get; init; }
    public string BoxOffice { get; init; }
    public string Production { get; init; }
    public string Website { get; init; }
    public bool Response { get; init; }
}