using System.ComponentModel.DataAnnotations;
using Backend_Management.Models;

namespace Backend_Management;

public class UserProfile : Entity
{
    [Required]
    public User User { get; set; }
    [Required]
    public Team Team { get; set; }
    [Required]
    public string FacebookLink { get; set; }
    [Required]
    [Phone]
    public string Phone { get; set; }
    [Required]
    public DateOnly Birthday { get; set; }
}