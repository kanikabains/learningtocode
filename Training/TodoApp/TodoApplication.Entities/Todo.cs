using System.ComponentModel.DataAnnotations;

namespace TodoApplication.Entities
{
	public class Todo
	{
		[Key]
		public int Id { get; set; }

		[Required, MaxLength(50)]
		public string? Title { get; set; }

		[Required, MaxLength(200)]
		public string? Description { get; set; }

		public bool Check { get; set; }
	}
}
