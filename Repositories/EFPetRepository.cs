using midterm_project.Migrations;
using midterm_project.Models;
using SQLitePCL;

namespace midterm_project.Repositories;

public class EFPetRepository: IPetRepository {
	private readonly PetDbContext _context;

	public EFPetRepository(PetDbContext context) {
		_context = context;
	}	

	public Pet CreatePet(Pet pet) {
		throw new NotImplementedException();
	}

	public Pet GetPetById(int id) {
		return _context.Pet.SingleOrDefault(p => p.Id == id);
	}

	public IEnumerable<Pet> GetAllPets() {
		throw new NotImplementedException();
	}

	public Pet UpdatePet(Pet pet) {
		throw new NotImplementedException();
	}

	public void DeletePetById(int id) {
		throw new NotImplementedException();
	}
}