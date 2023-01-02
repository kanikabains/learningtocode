using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeWebsite.Entities
{
	public class Programmes
	{
		[Required]
		public int Id { get; set; }

		[Required, MaxLength(100)]
		public string? Title { get; set; }

		[Required, MaxLength(1000)]
		public string? Description { get; set; }

		[Required]
		public string? PictureUrl { get; set; }
		public string? Url { get; set; }
	}
}
