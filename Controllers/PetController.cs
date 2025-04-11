using Microsoft.AspNetCore.Mvc;
using midterm_project.Migrations;
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
}