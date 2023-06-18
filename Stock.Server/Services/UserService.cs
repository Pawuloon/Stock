using Microsoft.EntityFrameworkCore;
using Stock.Server.Data;
using Stock.Shared.Models;

namespace Stock.Server.Services;

public class UserService : IUserService, IDisposable
{
    private readonly StockDbContext _context;

    public UserService(StockDbContext context)
    {
        _context = context;
    }

    public async Task<User> GetUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            throw new NullReferenceException();
        }
        return user;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();
        if (users == null)
        {
            throw new NullReferenceException();
        }
        return users;
    }

    public async Task AddUser(User user)
    {
        await _context.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User> UpdateUser(User user)
    {
        _context.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task DeleteUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new NullReferenceException();
        }
    }

    public async Task<User> GetUserByCredentials(User user)
    {
        var us = await _context.Users
            .FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Password == user.Password);
        if (us == null)
        {
            throw new NullReferenceException();
        }
        return us;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}