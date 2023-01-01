using CollegeWebsite.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeWebsite.Data
{
	public class ProgrammesDbContext : DbContext
	{
		public ProgrammesDbContext(DbContextOptions<ProgrammesDbContext> options) : base(options)
		{
		}
		public DbSet<Programmes> Programmes { get; set; }
		protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Programmes>(x => x.ToTable("Programmes"));
			modelBuilder.Seed();
		}
	}
}
