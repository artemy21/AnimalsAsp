using LibCore.Models;

namespace LibCore.Repositories
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<List<Comment>> GetAllCommentsByIdAsync(int animalId);
    }
}
