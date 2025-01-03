namespace Infrastructure.Identity.Models;

public class RefreshToken
{
	public int Id { get; set; }
	public string Value { get; set; }
	public DateTime ExpiresAt { get; set; }
	public string AccountId { get; set; }
}