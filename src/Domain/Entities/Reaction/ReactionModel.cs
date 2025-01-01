namespace Domain.Entities.Reaction;

public class ReactionModel
{
    public int Id { get; set; }
    
    public int PostId { get; set; }
    
    public int PersonId { get; set; }
    
    public int TypeId { get; set; }
}