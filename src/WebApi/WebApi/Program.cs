using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.IdentityModel.Tokens;
using WebApi.Middleware;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();
// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowSpecificOrigins",
        builder =>
        {
            builder.WithOrigins(Environment.GetEnvironmentVariable("WEBAPI_ALLOWED_ORIGINS")?.Split(' ') ??
                                new string[1] {"http://localhost"})
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
        });
});


builder.Services.AddControllers();
builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo("/tmp"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(4);
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.Cookie.SameSite = SameSiteMode.None;
    options.Cookie.HttpOnly = true;
    //options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer =  Environment.GetEnvironmentVariable("WEBAPI_JWT_ISSUER"),
        ValidAudience =  Environment.GetEnvironmentVariable("WEBAPI_JWT_AUDIENCE"),
        IssuerSigningKey = new
            SymmetricSecurityKey
            (Encoding.UTF8.GetBytes
                (Environment.GetEnvironmentVariable("WEBAPI_JWT_KEY") ?? string.Empty))
    };
});
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

WebApplication app = builder.Build();

//app.UseHttpsRedirection();

app.UseAppException();
app.UseCookiePolicy();
app.UseSession();

app.UseCors("AllowSpecificOrigins");
app.Use(async (context, next) =>
{
    string token = context.Session.GetString("Token");
    if (!string.IsNullOrEmpty(token))
    {
        context.Request.Headers.Add("Authorization", "Bearer " + token);
    }
    await next();
});
app.UseForwardedHeaders(new ForwardedHeadersOptions {
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseAuthorization();
app.MapControllers();

app.Run();