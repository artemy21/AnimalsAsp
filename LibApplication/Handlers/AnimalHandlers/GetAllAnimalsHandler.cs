using MediatR;
using LibCore.Models;
using LibCore.Repositories;
using LibApplication.Queries.GetAll;

namespace LibApplication.Handlers.AnimalHandlers
{
    public class GetAllAnimalsHandler : IRequestHandler<GetAllAnimalsQuery, List<Animal>?>
    {
        private readonly IAnimalRepository animalRepository;

        public GetAllAnimalsHandler(IAnimalRepository animalRepository) => this.animalRepository = animalRepository;

        public async Task<List<Animal>?> Handle(GetAllAnimalsQuery request, CancellationToken cancellationToken)
        {
            return await animalRepository.GetAllAsync() as List<Animal>;
        }
    }
}
