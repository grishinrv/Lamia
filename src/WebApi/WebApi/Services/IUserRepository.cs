using WebApi.Models;

namespace WebApi.Services;

public interface IUserRepository
{
    User GetUser(User user);
}