using MediatR;
using LibCore.Models;
using LibCore.Repositories;
using LibApplication.Queries.GetOne;

namespace LibApplication.Handlers.AnimalHandlers
{
    public class GetAnimalIdHandler : IRequestHandler<GetAnimalIdQuery, Animal?>
    {
        private readonly IAnimalRepository animalRepository;

        public GetAnimalIdHandler(IAnimalRepository animalRepository) => this.animalRepository = animalRepository;

        public async Task<Animal?> Handle(GetAnimalIdQuery request, CancellationToken cancellationToken)
        {
            return await animalRepository.GetByIdAsync(request.AnimalId); 
        }
    }
}
