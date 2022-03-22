using WebApi.Models;

namespace WebApi.Services;

public sealed class UserRepository : IUserRepository
{
    private readonly List<User> _userStorage;

    public UserRepository(IConfiguration config)
    {
        _userStorage = new List<User>();
        _userStorage.Add(new User {UserName = config["User:UserName"], Password = config["User:Password"]});
    }
    public User GetUser(User user)
    {
        return _userStorage.FirstOrDefault(x =>
            string.Equals(x.UserName, user.UserName, StringComparison.InvariantCultureIgnoreCase)
            && string.Equals(x.Password, user.Password, StringComparison.InvariantCultureIgnoreCase));
    }
}