using midterm_project.Models;

namespace midterm_project.Repositories;

public interface IPetRepository {
	public Pet CreatePet(Pet newPet); 
	public IEnumerable<Pet> GetAllPets();
	public Pet GetPetById(int id);
	public Pet UpdatePet(Pet petToUpdate);
	public void DeletePetById(int id);
}