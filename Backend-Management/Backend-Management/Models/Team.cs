using System.ComponentModel.DataAnnotations;

namespace Backend_Management.Models;

public class Team : Entity
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string GitHubLink { get; set; }
    
}