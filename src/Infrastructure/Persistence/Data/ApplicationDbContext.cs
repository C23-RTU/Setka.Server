using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Entities.Person;
using Domain.Entities.Club;
using Domain.Entities.Post;
using Domain.Entities.Reaction;

namespace Infrastructure.Persistence.Data;

public class ApplicationDbContext : DbContext
{
	public DbSet<PersonModel> t_Persons { get; set; }
	public DbSet<Institute> t_Institutes { get; set; }
	public DbSet<Role> t_Roles { get; set; }
	public DbSet<ActivityStatus> t_ActivityStatuses { get; set; }
	public DbSet<ClubModel> t_Clubs { get; set; }
	public DbSet<Administrator> t_Administrators { get; set; }
	public DbSet<ClubRole> t_ClubRoles { get; set; }
	public DbSet<PersonsClubs> t_Persons_Clubs { get; set; }
	public DbSet<PostModel> t_Posts { get; set; }
	public DbSet<PostsImages> t_Posts_Images { get; set; }
	public DbSet<ReactionModel> t_Reactions { get; set; }
	public DbSet<ReactionType> t_ReactionTypes { get; set; }
	public DbSet<Comment> t_Comments { get; set; }
	public DbSet<Image> t_Images { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
}