namespace Domain.Entities.Club;

public class Administrator
{
    public int Id { get; set; }

	public int PersonId { get; set; }

	public int ClubId { get; set; }

	public int ClubRoleId { get; set; }
}