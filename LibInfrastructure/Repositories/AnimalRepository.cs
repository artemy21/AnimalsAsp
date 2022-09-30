using LibCore.Models;
using LibCore.Repositories;
using LibInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibInfrastructure.Repositories
{
    public class AnimalRepository : Repository<Animal>, IAnimalRepository
    {
        public AnimalRepository(ProjContext projContext) : base(projContext)
        {
        }

        public async Task<Animal?> GetAnimalByNameAsync(string animalName)
        {
            return await projContext.Animals!.Where(a => a.Name == animalName).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Animal>> GetAnimalsByCategoryAsync(int categoryId)
        {
            return await projContext.Animals!.Where(a => a.CategoryId == categoryId).ToListAsync();
        }

        public async Task<IEnumerable<Animal>> GetTopAnimalsAsync(int count)
        {
            return await projContext.Animals!.Include(c => c.Comments)
                                             .OrderByDescending(c => c.Comments.Count)
                                             .Take(count)
                                             .ToListAsync();
        }
    }
}
