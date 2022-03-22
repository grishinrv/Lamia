using WebApi.Models;

namespace WebApi.Services;

public interface ITokenService
{
    /// <summary>
    /// Is used to build the token.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="issuer"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    string BuildToken(string key, string issuer, User user);
    /// <summary>
    /// Is used to check whether a given token is valid.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="issuer"></param>
    /// <param name="token"></param>
    /// <returns></returns>
    bool IsTokenValid(string key, string issuer, string token);
}