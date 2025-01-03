namespace Domain.Entities.Club;

public class ClubModel
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string? About { get; set; }
    
    public int? ImageId { get; set; }
}