using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeWebsite.Entities
{
	public class Courses
	{
		[Key]
		public int Id { get; set; }

		[Required, MaxLength(200)]
		public string? Course { get; set; }
	}
}
