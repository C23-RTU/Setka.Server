namespace Domain.Entities;

public class Post
{
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public string Content { get; set; }
    
    public int ClubId  { get; set; }
    
    public DateTime CreatedAt { get; set; }
}