using LibCore.Models;

namespace LibCore.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category?> GetCategoryByNameAsync(string categoryName);
    }
}
