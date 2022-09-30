using MediatR;
using LibCore.Models;
using LibApplication.Commands;
using Microsoft.AspNetCore.Mvc;
using LibApplication.Queries.GetAll;
using LibApplication.Queries.GetOne;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalsASP.Controllers
{
    public class HomeController : Controller
    {
        protected readonly IMediator mediator;

        public HomeController(IMediator mediator) => this.mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> Index() => View(await mediator.Send(new GetTopAnimalsQuery(2)));

        [HttpGet]
        public async Task<IActionResult> GetCatalog(int categoryId = 0)
        {
            await GetAllCategories(categoryId);

            List<Animal>? animals = categoryId == 0 ? await mediator.Send(new GetAllAnimalsQuery())
                                                    : await mediator.Send(new FilterByCategoryQuery(categoryId));

            return View(animals);
        }

        protected async Task GetAllCategories(int id = 0)
        {
            List<Category>? categories = await mediator.Send(new GetAllCategoriesQuery());
            if (id < 0 || id > categories!.Count) id = 0;
            var list = new SelectList(categories, "Id", "Name");
            if (id != 0) list.FirstOrDefault(x => x.Value == id.ToString())!.Selected = true;
            ViewBag.Categories = list;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimal(int animalId)
        {
            await mediator.Send(new GetAllCommentsQuery(animalId));
            var animal = await mediator.Send(new GetAnimalIdQuery(animalId));
            var animalView = new AnimalViewModel(animal, new CreateCommentCommand { AnimalId = animalId });
            return View(animalView);
        }

        [HttpPost]
        public async Task<IActionResult> GetAnimal(int animalId, string comment)
        {
            var command = new CreateCommentCommand { AnimalId = animalId, Content = comment };
            if (ModelState.IsValid) await mediator.Send(command);
            await mediator.Send(new GetAllCommentsQuery(command.AnimalId));
            var animal = await mediator.Send(new GetAnimalIdQuery(command.AnimalId));
            var animalView = new AnimalViewModel(animal, new CreateCommentCommand { AnimalId = command.AnimalId });
            return View(animalView);
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimalName(string name)
        {
            var animal = await mediator.Send(new GetAnimalNameQuery(name));
            if (animal == null) return NotFound404(name);
            await mediator.Send(new GetAllCommentsQuery(animal.Id));
            var animalView = new AnimalViewModel(animal, new CreateCommentCommand { AnimalId = animal.Id });
            return View("GetAnimal", animalView);
        }

        public IActionResult NotFound404(string name) => View("NotFound404", name);
    }
}
