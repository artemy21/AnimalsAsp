using LibCore.Models;
using LibCore.Repositories;
using LibInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibInfrastructure.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Model
    {
        protected readonly ProjContext projContext;

        public Repository(ProjContext projContext) => this.projContext = projContext;

        public async Task<IEnumerable<T>> GetAllAsync() => await projContext.Set<T>().ToListAsync();

        public async Task<T?> GetByIdAsync(int id) => await projContext.Set<T>().FindAsync(id);

        public async Task<T> AddAsync(T model)
        {
            await projContext.Set<T>().AddAsync(model);
            await projContext.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(T model)
        {
            projContext.Set<T>().Update(model);
            await projContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T model)
        {
            projContext.Set<T>().Remove(model);
            await projContext.SaveChangesAsync();
        }
    }
}
