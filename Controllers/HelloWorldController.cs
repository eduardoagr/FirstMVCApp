using FirstMVCApp.Models;

using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers;
public class HelloWorldController : Controller
{

    static readonly List<DogViewModel> dogs = new();
    public IActionResult Index()
    {
        return View(dogs);
    }

    public IActionResult Create()
    {
        var dogVM = new DogViewModel();
        return View(dogVM);
    }

    public IActionResult CreateDog(DogViewModel viewModel)
    {
        dogs.Add(viewModel);
        return RedirectToAction(nameof(Index));
    }

    public string Hello()
    {
        return "whose theree";
    }



}
