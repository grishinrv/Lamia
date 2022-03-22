using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;


[ApiController]
[Route("Movies")]
public sealed class MoviesController : ControllerBase
{
    private readonly ILogger<MoviesController> _logger;
    private readonly IConfiguration _config;

    private const string _openMovieDbUriStr = "http://www.omdbapi.com";
    private readonly Uri _openMovieDbUri = new Uri(_openMovieDbUriStr);

    public MoviesController(ILogger<MoviesController> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }

    [HttpPost("GetByParams")]
    public async Task<IActionResult> GetByParams(MovieParams dto)
    {
        if (dto == null)
            return BadRequest( new Error(ErrorType.ParameterIsMissing){Description = $"Parameter \"{nameof(dto)}\" is missing"});

        if (!ValidateDto(dto, out string error))
            return BadRequest( new Error(ErrorType.IncorrectParameterValue){Description = error});
        
        using (HttpClient apiClient = new HttpClient())
        {
            apiClient.BaseAddress = _openMovieDbUri;
            HttpRequestMessage request = BuildRequestMessage(dto);
            
            using (HttpResponseMessage response =
                   await apiClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
            {
                if (!response.IsSuccessStatusCode)
                    return StatusCode(502,
                        new Error(ErrorType.ExternalServiceError)
                            {Description = $"External error: {response.StatusCode}, {response.ReasonPhrase}"});
                
                string apiResponse = await response.Content.ReadAsStringAsync();
                _logger.LogTrace($"Get movie by params = {dto}, openMovieDb response = {apiResponse}");
                return Ok(JsonSerializer.Deserialize<Movie>(apiResponse));
            }
        }
    }

    private bool ValidateDto(MovieParams dto, out string error)
    {
        bool valid = string.Equals(dto.PlotVersion, "Full", StringComparison.InvariantCultureIgnoreCase) ||
               string.Equals(dto.PlotVersion, "Short", StringComparison.InvariantCultureIgnoreCase);
        error = valid ? string.Empty : "Invalid PlotVersion value: only \"Full\" or \"Short\" is allowed";
        return valid;
    }

    private HttpRequestMessage BuildRequestMessage(MovieParams dto)
    {
        StringBuilder builder = new StringBuilder(_openMovieDbUriStr);
        builder.Append("/?");
        builder.Append("apikey=");
        builder.Append(_config["OmdbApiKey"]);
        builder.Append("&t=");
        builder.Append(HttpUtility.UrlEncode(dto.Title));
        builder.Append("&y=");
        builder.Append(dto.Year);
        if (string.Equals(dto.PlotVersion, "Full", StringComparison.InvariantCultureIgnoreCase))
            builder.Append("&plot=full");
        
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, builder.ToString());
        return request;
    }
}