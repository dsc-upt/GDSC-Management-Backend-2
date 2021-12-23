using System.ComponentModel.DataAnnotations;
using Backend_Management.Models;
namespace Backend_Management.Views;

public class ProjectRequestView
{
    [Required]
    public string Name { get; set; }
    [Required]
    public User Manager { get; set; }
    [Required]
    public ICollection<Team> Teams { get; set; }
}