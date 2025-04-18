using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using midterm_project.Migrations;
using midterm_project.Models;
using midterm_project.Repositories;

namespace midterm_project.Controllers;

public class PetController: Controller {
	private readonly IPetRepository _repository;

	public PetController(IPetRepository repository) {
		_repository = repository;
	}

	public IActionResult Index() {
		return RedirectToAction("List");
	}

	[HttpGet]
	public IActionResult Create() {
		return View();
	}

	[HttpPost]
	public IActionResult Create(Pet newPet) {
		if (!ModelState.IsValid) {
			return View();
		}
		_repository.CreatePet(newPet);
		return RedirectToAction("Details", new {id = newPet.Id});
	}

	public IActionResult List() {
		return View(_repository.GetAllPets());
	}

	[HttpPost]
	public IActionResult Edit(Pet pet) {
		if (!ModelState.IsValid) {
			return View();
		}

		_repository.UpdatePet(pet);
		return RedirectToAction("Details", new {id = pet.Id});
	}

	public IActionResult Edit(int id) {
		var pet = _repository.GetPetById(id);

		if (pet == null) {
			return RedirectToAction("List");
		}

		return View(pet);
	}

	[HttpGet]
	public IActionResult Details(int id) {
		var pet = _repository.GetPetById(id);
		if (pet == null) return RedirectToAction("List");

		return View(pet);
	}

	public IActionResult Delete(int id) {
		_repository.DeletePetById(id);
		return RedirectToAction("List");
	}
}