using System.ComponentModel.DataAnnotations;

namespace CollegeWebsite.Models
{
	public class CollegeWebsiteViewModel
	{
		[Required]
		public string? Courses { get; set; }

		[Required, MaxLength(100)]
		public string? Name { get; set; }

		[Required]
		[EmailAddress]
		public string? Email { get; set; }

		[Required]
		public string? PhoneNumberExtension { get; set; }

		[Required, MaxLength(50)]
		public string? PhoneNumber { get; set; }

		[Required] 
		public string? City { get; set; }

		[Required]
		public string? State { get; set; }

		[Required, MaxLength(2000)]
		public string? Query { get; set; }
		

	}
}
