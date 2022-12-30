using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using TodoApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace TodoApplication.Data
{
	public class TodoApplicationDbContext : DbContext
	
	{
		public TodoApplicationDbContext(DbContextOptions<TodoApplicationDbContext> options) : base(options)
		{
		}
		public DbSet<Todo> Todo { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Todo>(x => x.ToTable("Todo"));
		}

	}
}


