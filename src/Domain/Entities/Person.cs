namespace Domain.Entities;

public class Person
{
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string? MiddleName { get; set; }
    
    public int Age { get; set; }
    
    public string? About { get; set; }
    
    public int? ImageId { get; set; }
    
    public int? InstituteId { get; set; }
    
    public int RoleId { get; set; }
    
    public int ActivityStatusId { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? DeletedAt { get; set; }
}