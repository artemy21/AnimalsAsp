using MediatR;
using LibCore.Models;
using LibApplication.Commands;
using Microsoft.AspNetCore.Mvc;
using LibApplication.Queries.GetOne;

namespace AnimalsASP.Controllers
{
    public class AdminController : HomeController
    {
        public AdminController(IMediator mediator) : base(mediator)
        {
        }

        public async Task<IActionResult> CreateAnimal()
        {
            await GetAllCategories();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnimal(CreateAnimalCommand command)
        {
            if (ModelState.IsValid) await mediator.Send(command);
            return Redirect("/Home/GetCatalog");
        }

        public async Task<IActionResult> DeleteAnimal(int animalId)
        {
            var animal = await mediator.Send(new GetAnimalIdQuery(animalId));
            await mediator.Send(new DeleteAnimalCommand { Animal = animal });
            return Redirect("/Home/GetCatalog");
        }

        public async Task<IActionResult> EditAnimal(int animalId)
        {
            await GetAllCategories();
            var animal = await mediator.Send(new GetAnimalIdQuery(animalId));
            return View(animal);
        }

        public async Task<IActionResult> SubmitEditAnimal(Animal animal)
        {
            await mediator.Send(new UpdateAnimalCommand(animal));
            return RedirectToAction("GetAnimal", new { animalId = animal.Id });
        }
    }
}
