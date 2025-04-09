using Microsoft.EntityFrameworkCore;
using midterm_project.Models;

namespace midterm_project.Migrations;

public class PetDbContext: DbContext {
	public DbSet<Pet> Pet { get; set; }

	public PetDbContext(DbContextOptions<PetDbContext> options): base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Pet>(entity => {
			entity.Property(e => e.Name);
			entity.Property(e => e.Description);
			entity.Property(e => e.Url);
		});
    }
}