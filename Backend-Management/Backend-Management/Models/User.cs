using System.ComponentModel.DataAnnotations;

namespace Backend_Management.Models;

public class User : Entity
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}