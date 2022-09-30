using LibCore.Models;
using LibCore.Repositories;
using LibInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibInfrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProjContext projContext) : base(projContext)
        {
        }

        public async Task<Category?> GetCategoryByNameAsync(string categoryName)
        {
            return await projContext.Categories!.Where(c => c.Name == categoryName).FirstOrDefaultAsync();
        }
    }
}
