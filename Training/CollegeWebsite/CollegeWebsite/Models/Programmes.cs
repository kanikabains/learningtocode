using System.ComponentModel.DataAnnotations;

namespace CollegeWebsite.Models
{
	public class Programmes
	{ 
		[Required, MaxLength(100)]
		public string? Title { get; set; }

		[Required, MaxLength(1000)]
		public string? Description { get; set; }

		[Required]
		public string? PicureUrl { get; set; }
	}
}
