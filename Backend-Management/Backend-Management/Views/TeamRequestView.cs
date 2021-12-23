using System.ComponentModel.DataAnnotations;
namespace Backend_Management.Views;

public class TeamRequestView
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string GitHubLink { get; set; }
}