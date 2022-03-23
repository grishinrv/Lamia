using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.IdentityModel.Tokens;
using WebApi.Middleware;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.AddEnvironmentVariables(prefix: "webapi_");
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer =  builder.Configuration["Jwt:Issuer"],
        ValidAudience =  builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new
            SymmetricSecurityKey
            (Encoding.UTF8.GetBytes
                (builder.Configuration["Jwt:Key"]))
    };
});
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseAppException();
app.UseSession();
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

app.Run();