using MediatR;
using LibCore.Models;
using LibCore.Repositories;
using LibApplication.Commands;

namespace LibApplication.Handlers.CategoryHandlers
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, Category>
    {
        private readonly ICategoryRepository categoryRepository;

        public CreateCategoryHandler(ICategoryRepository categoryRepository) => this.categoryRepository = categoryRepository;

        public async Task<Category> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category { Name = request.Name };
            return await categoryRepository.AddAsync(category);
        }
    }
}
