using Microsoft.EntityFrameworkCore;
using Backend_Management.Models;
using Backend_Management.Views;
using Microsoft.EntityFrameworkCore.Internal;

namespace Backend_Management.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) {}
    public DbSet<User> Users { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Team> Teams { get; set; }
}