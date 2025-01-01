namespace Domain.Entities;

public class Image
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Path { get; set; }
    
    public DateTime CreatedAt { get; set; }
}