namespace Domain.Entities;

public class Reaction
{
    public int Id { get; set; }
    
    public int PostId { get; set; }
    
    public int PersonId { get; set; }
    
    public int Type { get; set; }
}