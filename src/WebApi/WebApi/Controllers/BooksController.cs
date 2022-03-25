using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers;

[ApiController]
[Route("api/Books")]
[Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public sealed class BooksController : ControllerBase
{
    private readonly ILogger<BooksController> _logger;

    private const string _openLibraryUriStr = "https://openlibrary.org";
    private readonly Uri _openLibraryUri = new Uri(_openLibraryUriStr);

    public BooksController(ILogger<BooksController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetByIsbn")]
    public async Task<IActionResult> GetByIsbn(string isbn)
    {
        _logger.LogTrace($"{nameof(GetByIsbn)}: {isbn}");
        if (string.IsNullOrWhiteSpace(isbn))
            return BadRequest( new Error(ErrorType.ParameterIsMissing){Description = $"Parameter \"{nameof(isbn)}\" is missing"});
        
        using (HttpClient apiClient = new HttpClient())
        {
            apiClient.BaseAddress = _openLibraryUri;
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, _openLibraryUriStr + $"/isbn/{isbn}.json");
            using (HttpResponseMessage response =
                   await apiClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
            {
                if (!response.IsSuccessStatusCode)
                    return StatusCode(502,
                        new Error(ErrorType.ExternalServiceError)
                            {Description = $"External error: {response.StatusCode}, {response.ReasonPhrase}"});
                
                string apiResponse = await response.Content.ReadAsStringAsync();
                _logger.LogTrace($"Get book by ISBN = {isbn}, openLibrary response = {apiResponse}");
                return Ok(JsonSerializer.Deserialize<Book>(apiResponse));
            }
        }
    }
}