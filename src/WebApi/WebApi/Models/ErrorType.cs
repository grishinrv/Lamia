namespace WebApi.Models;

public enum ErrorType
{
    ParameterIsMissing = 0,
    ExternalServiceError = 1,
    InternalServerError = 2,
}