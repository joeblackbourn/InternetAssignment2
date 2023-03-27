using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InternetAssignment2.Data;

public class AppDataContext : DbContext
{
	public AppDataContext(DbContextOptions<AppDataContext> options)
				: base(options)
	{ }
	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
		builder.Entity<IdentityRole>().HasData(
			new IdentityRole
			{
				Name = "Visitor",
				NormalizedName = "VISITOR"
			}
			);
		builder.Entity<IdentityRole>().HasData(
			new IdentityRole
			{
				Name = "Admin",
				NormalizedName = "ADMIN"
			}
			);

	}

			
}
