using LibCore.Models;

namespace LibCore.Repositories
{
    public interface IRepository<T> where T : Model
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task<T> AddAsync(T model);
        Task UpdateAsync(T model);
        Task DeleteAsync(T model);
    }
}
