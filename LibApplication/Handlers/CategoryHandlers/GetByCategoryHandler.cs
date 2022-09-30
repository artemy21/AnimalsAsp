using MediatR;
using LibCore.Models;
using LibApplication.Queries.GetAll;
using LibCore.Repositories;

namespace LibApplication.Handlers.CategoryHandlers
{
	public class GetByCategoryHandler : IRequestHandler<FilterByCategoryQuery, List<Animal>?>
	{
        private readonly IAnimalRepository animalRepository;

        public GetByCategoryHandler(IAnimalRepository animalRepository) => this.animalRepository = animalRepository;

        public async Task<List<Animal>?> Handle(FilterByCategoryQuery request, CancellationToken cancellationToken)
		{
            return await animalRepository.GetAnimalsByCategoryAsync(request.CategoryId) as List<Animal>;
        }
	}
}
