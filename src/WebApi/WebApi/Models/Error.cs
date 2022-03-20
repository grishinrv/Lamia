namespace WebApi.Models;

public record Error
{
    public Error(ErrorType type)
    {
        switch (type)
        {
            case Models.ErrorType.ParameterIsMissing:
                ErrorType = "Parameter is missing";
                break;
            case Models.ErrorType.ExternalServiceError:
                ErrorType = "External service error";                
                break;
            default:
                ErrorType = "Undefined";
                break;
        }
    }

    public string ErrorType { get; }

    public string Description { get; init; }
}