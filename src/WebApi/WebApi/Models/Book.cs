namespace WebApi.Models;

public record Book
{
    /// <summary>
    /// publishers
    /// </summary>
    public List<string> Publishers { get; init; }
    /// <summary>
    /// number_of_pages
    /// </summary>
    public int NumberOfPages { get; init; }
    /// <summary>
    /// isbn_10
    /// </summary>
    public List<string> Isbn10 { get; init; }
    /// <summary>
    /// covers
    /// </summary>
    public int Covers { get; init; }
    /// <summary>
    /// key
    /// </summary>
    public string Key { get; init; }
    /// <summary>
    /// authors
    /// </summary>
    public List<Author> Authors { get; init; }
    /// <summary>
    /// ocaid
    /// </summary>
    public string Ocaid { get; init; }
    /// <summary>
    /// contributions
    /// </summary>
    public List<string> Contributions { get; init; }
    /// <summary>
    /// languages
    /// </summary>
    public List<Link> Languages { get; init; }
    /// <summary>
    /// classifications
    /// </summary>
    public dynamic Classifications { get; init; }
    /// <summary>
    /// source_records
    /// </summary>
    public List<string> SourceRecords { get; init; }
    /// <summary>
    /// title
    /// </summary>
    public string Title { get; init; }
    /// <summary>
    /// identifiers
    /// </summary>
    public Identifiers Identifiers { get; init; }
    /// <summary>
    /// isbn_13
    /// </summary>
    public List<string> Isbn13 { get; init; }
    /// <summary>
    /// local_id
    /// </summary>
    public List<string> LocalIds { get; init; }
    /// <summary>
    /// publish_date
    /// </summary>
    public string PublishDateStr { get; init; }
    /// <summary>
    /// works
    /// </summary>
    public List<Link> Works { get; init; }
    /// <summary>
    /// type
    /// </summary>
    public Link Type { get; init; }
    /// <summary>
    /// first_sentence
    /// </summary>
    public JsonValue FirstSentence { get; init; }
    /// <summary>
    /// latest_revision
    /// </summary>
    public int LatestVersion { get; init; }
    /// <summary>
    /// revision
    /// </summary>
    public int Revision { get; init; }
    /// <summary>
    /// created
    /// </summary>
    public JsonValue Created { get; init; }
    /// <summary>
    /// last_modified
    /// </summary>
    public JsonValue LastModified { get; set; }
}