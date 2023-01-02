using System.ComponentModel.DataAnnotations;

namespace CollegeWebsite.Models
{
	public class ProgrammesModel
	{
        public string? Title { get; set; }

		public string? Description { get; set; }

		public string? PictureUrl { get; set; }

		public string? Url { get; set; }
	}
}
