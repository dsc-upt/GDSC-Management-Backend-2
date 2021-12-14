namespace Backend_Management.Models;

public abstract class Entity
{
    protected string Id { get; set; }
    protected DateTime Created { get; set; }
    protected DateTime Updated { get; set; }
    
}