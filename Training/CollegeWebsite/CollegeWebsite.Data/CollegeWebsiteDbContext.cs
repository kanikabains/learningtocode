using Microsoft.EntityFrameworkCore;
using CollegeWebsite.Entities;
namespace CollegeWebsite.Data
{
	public class CollegeWebsiteDbContext : DbContext
	{
	   public CollegeWebsiteDbContext(DbContextOptions<CollegeWebsiteDbContext> options) : base(options) 
		{ 
		}
		public DbSet<College> College { get; set; }

		protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<College>(x => x.ToTable("College"));
			modelBuilder.Entity<Courses>(x => x.ToTable("Courses"));
			modelBuilder.Seed();
			modelBuilder.Seed(Programmes);
		}
		public DbSet<College> Courses { get; set; }

		public DbSet<College> Programmes { get; set; }
	}
}