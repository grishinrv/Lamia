namespace WebApi.Middleware;

public static class MiddlewareRegistrationExtensions
{
    public static void UseAppException(this IApplicationBuilder builder)
    {
        builder.UseMiddleware<ErrorHandlingMiddleware>();
    }
}