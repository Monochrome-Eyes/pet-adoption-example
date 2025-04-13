using Microsoft.EntityFrameworkCore;
using midterm_project.Models;

namespace midterm_project.Migrations;

public class PetDbContext: DbContext {
	public DbSet<Pet> Pet { get; set; }

	public PetDbContext(DbContextOptions<PetDbContext> options): base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Pet>(entity => {
			entity.HasKey(e => e.Id);
			entity.Property(e => e.Name).IsRequired();
			entity.Property(e => e.Description).IsRequired();
			entity.Property(e => e.ImgUrl).IsRequired();
		});
    }
}