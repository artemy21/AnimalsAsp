using MediatR;
using LibCore.Models;
using LibCore.Repositories;
using LibApplication.Queries.GetOne;

namespace LibApplication.Handlers.AnimalHandlers
{
    public class GetAnimalNameHandler : IRequestHandler<GetAnimalNameQuery, Animal?>
    {
        private readonly IAnimalRepository animalRepository;

        public GetAnimalNameHandler(IAnimalRepository animalRepository) => this.animalRepository = animalRepository;

        public async Task<Animal?> Handle(GetAnimalNameQuery request, CancellationToken cancellationToken)
        {
            return await animalRepository.GetAnimalByNameAsync(request.AnimalName);
        }
    }
}
