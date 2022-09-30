using MediatR;
using LibCore.Models;
using LibCore.Repositories;
using LibApplication.Commands;

namespace LibApplication.Handlers.AnimalHandlers
{
    public class CreateAnimalHandler : IRequestHandler<CreateAnimalCommand, Animal>
    {
        private readonly IAnimalRepository animalRepository;

        public CreateAnimalHandler(IAnimalRepository animalRepository) => this.animalRepository = animalRepository;

        public async Task<Animal> Handle(CreateAnimalCommand request, CancellationToken cancellationToken)
        {
            var animal = new Animal
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                CategoryId = request.CategoryId
            };
            return await animalRepository.AddAsync(animal);
        }
    }
}
