using System.ComponentModel.DataAnnotations;
using Backend_Management.Models;

namespace Backend_Management.Views;

public class UserResponseView 
{
    public string Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}