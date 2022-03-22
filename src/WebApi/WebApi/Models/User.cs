using System.Text.Json.Serialization;

namespace WebApi.Models;

public record User
{
    [JsonPropertyName("UserName")]
    public string UserName { get; init; }
    [JsonPropertyName("Password")]
    public string Password { get; init; }
}