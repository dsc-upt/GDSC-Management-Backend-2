using System.ComponentModel.DataAnnotations;
using Backend_Management.Models;

namespace Backend_Management;

public class Project : Entity
{
    [Required]
    public string Name { get; set; }
    [Required]
    public User 
}