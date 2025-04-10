using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace midterm_project.Models;

public class Pet {
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	[Required]
	public string? Name { get; set; }

	[Required]
	public string? Description { get; set; }

	[Required]
	public string? Url { get; set; }
}