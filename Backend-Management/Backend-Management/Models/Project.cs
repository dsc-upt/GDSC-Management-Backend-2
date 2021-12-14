using System.ComponentModel.DataAnnotations;

namespace Backend_Management.Models;

public class Project : Entity
{
    [Required]
    public string Name { get; set; }
    [Required]
    public User Manager { get; set; }
    [Required]
    public ICollection<Team> Teams { get; set; }
}