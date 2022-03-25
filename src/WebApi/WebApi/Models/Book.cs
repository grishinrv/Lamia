using System.Text.Json.Serialization;

namespace WebApi.Models;

public record Book
{
    /// <summary>
    /// publishers
    /// </summary>
    [JsonPropertyName("publishers")]
    public List<string> Publishers { get; init; }
    /// <summary>
    /// number_of_pages
    /// </summary>
    [JsonPropertyName("number_of_pages")]
    public int NumberOfPages { get; init; }
    /// <summary>
    /// isbn_10
    /// </summary>
    [JsonPropertyName("isbn_10")]
    public List<string> Isbn10 { get; init; }
    /// <summary>
    /// covers
    /// </summary>
    [JsonPropertyName("covers")]
    public List<int> Covers { get; init; }
    /// <summary>
    /// key
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; init; }
    /// <summary>
    /// authors
    /// </summary>
    [JsonPropertyName("authors")]
    public List<Link> Authors { get; init; }
    /// <summary>
    /// ocaid
    /// </summary>
    [JsonPropertyName("ocaid")]
    public string Ocaid { get; init; }
    /// <summary>
    /// contributions
    /// </summary>
    [JsonPropertyName("contributions")]
    public List<string> Contributions { get; init; }
    /// <summary>
    /// languages
    /// </summary>
    [JsonPropertyName("languages")]
    public List<Link> Languages { get; init; }
    /// <summary>
    /// classifications
    /// </summary>
    [JsonPropertyName("classifications")]
    public dynamic Classifications { get; init; }
    /// <summary>
    /// source_records
    /// </summary>
    [JsonPropertyName("source_records")]
    public List<string> SourceRecords { get; init; }
    /// <summary>
    /// title
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; init; }
    /// <summary>
    /// identifiers
    /// </summary>
    [JsonPropertyName("identifiers")]
    public Identifiers Identifiers { get; init; }
    /// <summary>
    /// isbn_13
    /// </summary>
    [JsonPropertyName("isbn_13")]
    public List<string> Isbn13 { get; init; }
    /// <summary>
    /// local_id
    /// </summary>
    [JsonPropertyName("local_id")]
    public List<string> LocalIds { get; init; }
    /// <summary>
    /// publish_date
    /// </summary>
    [JsonPropertyName("publish_date")]
    public string PublishDateStr { get; init; }
    /// <summary>
    /// works
    /// </summary>
    [JsonPropertyName("works")]
    public List<Link> Works { get; init; }
    /// <summary>
    /// type
    /// </summary>
    [JsonPropertyName("type")]
    public Link Type { get; init; }
    /// <summary>
    /// first_sentence
    /// </summary>
    [JsonPropertyName("first_sentence")]
    public JsonValue FirstSentence { get; init; }
    /// <summary>
    /// latest_revision
    /// </summary>
    [JsonPropertyName("latest_revision")]
    public int LatestVersion { get; init; }
    /// <summary>
    /// revision
    /// </summary>
    [JsonPropertyName("revision")]
    public int Revision { get; init; }
    /// <summary>
    /// created
    /// </summary>
    [JsonPropertyName("created")]
    public JsonValue Created { get; init; }
    /// <summary>
    /// last_modified
    /// </summary>
    [JsonPropertyName("last_modified")]
    public JsonValue LastModified { get; set; }
}