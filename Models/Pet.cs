using System.ComponentModel.DataAnnotations;

namespace midterm_project.Models;

public class Pet {
	public int Id { get; set; }

	[Required]
	public string Name { get; set; }

	[Required]
	public string Description { get; set; }

	[Required]
	public string Url { get; set; }
}