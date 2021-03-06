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
            case Models.ErrorType.InternalServerError:
                ErrorType = "Internal server error";
                break;
            case Models.ErrorType.IncorrectParameterValue:
                ErrorType = "Parameter value is incorrect";                
                break;
            default:
                ErrorType = "Undefined";
                break;
        }
    }

    public string ErrorType { get; }

    public string Description { get; init; }
}