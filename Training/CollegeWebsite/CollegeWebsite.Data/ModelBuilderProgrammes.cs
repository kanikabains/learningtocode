using CollegeWebsite.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeWebsite.Data
{
	public static class ModelBuilderProgrammes
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			_ = modelBuilder.Entity<Programmes>().HasData(
				new Programmes
				{
					Id = 1,
					Title = "Engineering & Technology",
					Description = "B.Tech | M.Tech | P.hD",
					PicureUrl = "http://cpuh.in/wp-content/uploads/2022/02/engineering.jpg"
				},

				new Programmes
				{
					Id = 2,
					Title = "Basic & Applied Sciences",
					Description = "B.Sc. (PCMB) | M.Sc. (PCMB)| P.hD",
					PicureUrl = "http://cpuh.in/wp-content/uploads/2022/02/science.jpg"
				},

				new Programmes
				{
					Id = 3,
					Title = "Business & Management Studies",
					Description = "B.Com | M.Com | BBA | MBA| P.hD",
					PicureUrl = "http://cpuh.in/wp-content/uploads/2022/02/management.jpg"
				},

				new Programmes
				{
					Id = 4,
					Title = "Computer Science",
					Description = "BCA I MCA | B.Sc.(IT) | M.Sc.(IT) |DCA | PGDCA",
					PicureUrl = "http://cpuh.in/wp-content/uploads/2022/03/csaw-18-laptop.png"
				}
				 );
		}
	}
}