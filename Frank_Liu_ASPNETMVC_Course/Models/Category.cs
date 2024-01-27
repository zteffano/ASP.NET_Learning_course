using System.ComponentModel.DataAnnotations;

namespace Frank_Liu_ASPNETMVC_Course.Models
{
	public class Category
	{
        public int Id { get; set; }

        [Required]
		public string Name { get; set; } = string.Empty;
		
		public string? Description { get; set; }= string.Empty;

    }
}
