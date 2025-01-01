namespace Domain.Entities;

public class Comment
{
    public int Id { get; set; }
    
    public string Content { get; set; }
    
    public int PersonId { get; set; }
    
    public int? ParentId { get; set; }
    
    public int PostId { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? DeletedAt { get; set; }
}