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
    public async Task<User> PostUser(User entity)
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
        var result = await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    // [HttpGet]
    // public async Task<User> GetUsers()
    // {
    //     
    // }
}