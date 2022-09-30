using MediatR;
using LibCore.Models;
using LibCore.Repositories;
using LibApplication.Queries.GetAll;

namespace LibApplication.Handlers.AnimalHandlers
{
    public class GetTopAnimalsHandler : IRequestHandler<GetTopAnimalsQuery, List<Animal>?>
    {
        private readonly IAnimalRepository animalRepository;

        public GetTopAnimalsHandler(IAnimalRepository animalRepository) => this.animalRepository = animalRepository;

        public async Task<List<Animal>?> Handle(GetTopAnimalsQuery request, CancellationToken cancellationToken)
        {
            return await animalRepository.GetTopAnimalsAsync(request.Count) as List<Animal>;
        }
    }
}
