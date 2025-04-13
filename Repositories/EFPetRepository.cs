using midterm_project.Migrations;
using midterm_project.Models;
using SQLitePCL;

namespace midterm_project.Repositories;

public class EFPetRepository: IPetRepository {
	private readonly PetDbContext _context;

	public EFPetRepository(PetDbContext context) {
		_context = context;
	}	

	public Pet CreatePet(Pet newPet) {
		_context.Pet.Add(newPet);
		_context.SaveChanges();
		return newPet;
	}

	public Pet? GetPetById(int id) {
		return _context.Pet.SingleOrDefault(p => p.Id == id);
	}

	public IEnumerable<Pet> GetAllPets() {
		return _context.Pet.ToList();
	}

	public Pet UpdatePet(Pet pet) {
		var originalPet = _context.Pet.Find(pet.Id);
		if (originalPet != null) {
			originalPet.Name = pet.Name;
			originalPet.Description = pet.Description;
			originalPet.ImgUrl = pet.ImgUrl;
			_context.SaveChanges();
		}
		return pet;
	}

	public void DeletePetById(int id) {
		var pet = _context.Pet.Find(id);
		if (pet != null) {
			_context.Pet.Remove(pet);
			_context.SaveChanges();
		}
	}
}