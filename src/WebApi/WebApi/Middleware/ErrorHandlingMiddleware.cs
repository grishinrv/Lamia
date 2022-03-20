using WebApi.Models;

namespace WebApi.Middleware;

public sealed class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _requestDelegate;
    private readonly ILogger<ErrorHandlingMiddleware> _logger;
       
    public ErrorHandlingMiddleware(RequestDelegate requestDelegate, ILogger<ErrorHandlingMiddleware> logger)
    {
        _requestDelegate = requestDelegate;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _requestDelegate(context);
        }
        catch (Exception ex)
        {
            context.Response.StatusCode = 500;
            _logger.LogError(ex, $"An error acquired, while processing request to {context.GetEndpoint()}");
            await context.Response.WriteAsJsonAsync(new Error(ErrorType.InternalServerError));
        }
    }
}