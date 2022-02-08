using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend_Management.Database;
using Backend_Management.Models;
using Backend_Management.Views;

namespace Backend_Management.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public UsersController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<UserResponseView> PostUser(UserRequestView entity)
    {
        var user = new User
        {
            Id = Guid.NewGuid().ToString(),
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
        };
        var response = new UserResponseView
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
        };
        var result = await _dbContext.Users.AddAsync(user/*response*/);
        await _dbContext.SaveChangesAsync();
        return response;
    }

    [HttpGet]
    public async Task<List<User>> GetUsers()
    {
        return await _dbContext.Users.ToListAsync();
    }

    [HttpGet("api/users/{id}")]
    public async Task<User> GetUsersById([FromRoute] string id)
    {
        var user = await _dbContext.Users.FindAsync(id);
        if (user == null)
        {
            throw new ArgumentException("Id not found");
        }
        return user;
    }
    [HttpDelete("api/users/{id}")]
    public async Task<User> DeleteUser([FromRoute]string id)
    {
        var user = await _dbContext.Users.FindAsync(id);
        if (user == null)
        {
            throw new ArgumentException("Id not found");
        }

        var result = _dbContext.Users.Remove(user);
        return result.Entity;
    }
}