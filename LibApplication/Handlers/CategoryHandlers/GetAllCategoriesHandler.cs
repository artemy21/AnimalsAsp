using MediatR;
using LibCore.Models;
using LibCore.Repositories;
using LibApplication.Queries.GetAll;

namespace LibApplication.Handlers.CategoryHandlers
{
    public class GetAllCategoriesHandler : IRequestHandler<GetAllCategoriesQuery, List<Category>?>
    {
        private readonly ICategoryRepository categoryRepository;

        public GetAllCategoriesHandler(ICategoryRepository categoryRepository) => this.categoryRepository = categoryRepository;

        public async Task<List<Category>?> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await categoryRepository.GetAllAsync() as List<Category>;
        }
    }
}
