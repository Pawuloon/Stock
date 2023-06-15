using Stock.Shared.Models;

namespace Stock.Server.Services;

public interface IUserService
{
    Task<User> GetUser(int id);
    Task<IEnumerable<User>> GetUsers();
    Task AddUser(User user);
    Task<User> UpdateUser(User user);
    Task DeleteUser(int id);
    
}