using Microsoft.EntityFrameworkCore;
using CollegeWebsite.Entities;
namespace CollegeWebsite.Data
{
	public class CollegeWebsiteDbContext : DbContext
	{
		public CollegeWebsiteDbContext(DbContextOptions<CollegeWebsiteDbContext> options) : base(options)
		{
		}
		public DbSet<Admissions> Admissions { get; set; }

		public DbSet<Courses> Courses { get; set; }

		public DbSet<Programmes> Programmes { get; set; }

		protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Admissions>(x => x.ToTable("Admissions"));
			modelBuilder.Entity<Courses>(x => x.ToTable("Courses"));
			modelBuilder.Entity<Programmes>(x => x.ToTable("Programmes"));

			modelBuilder.Entity<Courses>().HasData(
				new Courses
				{
					Id = 1,
					Course = "BCA"
				},

				new Courses
				{
					Id = 2,
					Course = "MCA"
				},

				new Courses
				{
					Id = 3,
					Course = "BBA"
				},

				new Courses
				{
					Id = 4,
					Course = "MBA"
				},

				new Courses
				{
					Id = 5,
					Course = "Bsc"
				},

				new Courses
				{
					Id = 6,
					Course = "Msc"
				},

				new Courses
				{
					Id = 7,
					Course = "PhD"
				}
				 );

			modelBuilder.Entity<Programmes>().HasData(
				new Programmes
				{
					Id = 1,
					Title = "Engineering & Technology",
					Description = "B.Tech | M.Tech | P.hD",
					PictureUrl = "~/images/programmes/engineering.jpg",
					Url = "engineering"
				},

				new Programmes
				{
					Id = 2,
					Title = "Basic & Applied Sciences",
					Description = "B.Sc. (PCMB) | M.Sc. (PCMB)| P.hD",
					PictureUrl = "~/images/programmes/science.jpg",
					Url = "science"
				},

				new Programmes
				{
					Id = 3,
					Title = "Business & Management Studies",
					Description = "B.Com | M.Com | BBA | MBA| P.hD",
					PictureUrl = "~/images/programmes/management.jpg",
					Url = "management"
				},

				new Programmes
				{
					Id = 4,
					Title = "Computer Science",
					Description = "BCA I MCA | B.Sc.(IT) | M.Sc.(IT) |DCA | PGDCA",
					PictureUrl = "~/images/programmes/computer.png",
					Url = "computer-science"
				}
				 );
		}
	}
}