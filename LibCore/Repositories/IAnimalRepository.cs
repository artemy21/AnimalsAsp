using LibCore.Models;

namespace LibCore.Repositories
{
    public interface IAnimalRepository : IRepository<Animal>
    {
        Task<Animal?> GetAnimalByNameAsync(string animalName);
        Task<IEnumerable<Animal>> GetAnimalsByCategoryAsync(int categoryId);
        Task<IEnumerable<Animal>> GetTopAnimalsAsync(int count);
    }
}
