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
		return RedirectToAction("Create");
		// return View();
	}

	[HttpGet]
	public IActionResult Create() {
		return View();
	}

	[HttpPost]
	public IActionResult Create(Pet newPet) {
		if (!ModelState.IsValid) {
			Console.WriteLine("Not worky");
			return View();
		}
		_repository.CreatePet(newPet);
		return RedirectToAction("List");
	}

	public IActionResult List() {
		return View(_repository.GetAllPets());
	}
}