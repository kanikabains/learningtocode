using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeWebsite.Entities;

namespace CollegeWebsite.Data
{
	public static class ModelBuilderCourses
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			_ = modelBuilder.Entity<Courses>().HasData(
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
		}
	}
}
