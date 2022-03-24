using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/Home")]
public sealed class HomeController : ControllerBase
{
    private readonly IConfiguration _config;        
    private readonly IUserRepository _userRepository;       
    private readonly ITokenService _tokenService; 
    private readonly ILogger<HomeController> _logger;
    private string _generatedToken;  
    
    public HomeController (IConfiguration config, ITokenService tokenService, IUserRepository userRepository, ILogger<HomeController> logger)
    {
        _config = config;
        _tokenService = tokenService;
        _userRepository = userRepository;
        _logger = logger;
    }

    [AllowAnonymous]   
    [HttpPost("Login")]  
    public IActionResult Login([FromBody] User user)
    {
        if (user == null)
        {
            _logger.LogTrace($"{nameof(Login)}: Parameter \"{nameof(user)}\" is missing");
            return BadRequest( new Error(ErrorType.ParameterIsMissing){Description = $"Parameter \"{nameof(user)}\" is missing"});
        }

        if (string.IsNullOrEmpty(user.UserName))
        {
            _logger.LogTrace($"{nameof(Login)}: \"UserName\" is missing");
            return BadRequest( new Error(ErrorType.ParameterIsMissing){Description = $"\"UserName\" is missing"});
        }


        if (string.IsNullOrEmpty(user.Password))
        {
            _logger.LogTrace($"{nameof(Login)}: \"Password\" is missing");
            return BadRequest( new Error(ErrorType.ParameterIsMissing){Description = $"\"Password\" is missing"});
        }

        
        IActionResult response = Unauthorized();        
        User validUser = GetUser(user);
    
        if (validUser != null)  
        {
            _generatedToken = _tokenService.BuildToken(Environment.GetEnvironmentVariable("WEBAPI_JWT_KEY"), 
                Environment.GetEnvironmentVariable("WEBAPI_JWT_ISSUER"), validUser);
            if (!string.IsNullOrEmpty(_generatedToken)) 
            {
                HttpContext.Session.SetString("Token", _generatedToken);
                return RedirectToAction("Auth"); 
            }
            else
            {
                throw new ApplicationException("Failed to generate token!"); 
            }
        }
        else
        {
            _logger.LogTrace($"{nameof(Login)}: User not exists or password is wrong");
            return NotFound(new Error(ErrorType.IncorrectParameterValue)
                {Description = "User not exists or password is wrong"});
        }
    }

    private User GetUser(User userModel)        
    {
        // Write your code here to authenticate the user     
        return _userRepository.GetUser(userModel);
    }

    [Authorize]
    [Route("Auth")]
    [HttpGet]
    public IActionResult Auth()
    {
        string baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
        string token = HttpContext.Session.GetString("Token");
        if (token == null)
            return Redirect(baseUrl + "/LoginForm");
        
        if (!_tokenService.IsTokenValid(Environment.GetEnvironmentVariable("WEBAPI_JWT_KEY"), Environment.GetEnvironmentVariable("WEBAPI_JWT_ISSUER"), token)) 
            return Redirect(baseUrl + "/LoginForm");
        
        HttpContext.Response.Headers.Add("Token", FormatString(token, 50));
        return Redirect(baseUrl + "/MainForm");
    }


    private string FormatString(string stringToSplit, int chunkSize)
    {
        IEnumerable<string> data = Enumerable.Range(0, stringToSplit.Length / chunkSize).Select(i => stringToSplit.Substring (i * chunkSize, chunkSize));
        string result = string.Empty;
        foreach (string str in data)            
        {
            result += Environment.NewLine + str;
        }
        return result;      
    }    
}