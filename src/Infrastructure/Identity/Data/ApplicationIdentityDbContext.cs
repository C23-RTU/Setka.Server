using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Identity.Models;

namespace Infrastructure.Identity.Data;

public class ApplicationIdentityDbContext : IdentityDbContext<Account>
{
	public DbSet<RefreshToken> t_RefreshTokens { get; set; }

	public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : base(options) {}
}