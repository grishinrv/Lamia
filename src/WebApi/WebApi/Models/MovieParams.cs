using System.Text.Json.Serialization;

namespace WebApi.Models;

public record MovieParams
{
    [JsonPropertyName("Title")]
    public string Title { get; init; }
    [JsonPropertyName("Year")]
    public int Year { get; init; }
    [JsonPropertyName("PlotVersion")]
    public string PlotVersion { get; init; }

    public override string ToString() => $"Title: {Title}, Year: {Year}, PlotVersion: {PlotVersion}";
}