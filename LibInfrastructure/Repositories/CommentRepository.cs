using LibCore.Models;
using LibCore.Repositories;
using LibInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibInfrastructure.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(ProjContext projContext) : base(projContext)
        {
        }

        public async Task<List<Comment>> GetAllCommentsByIdAsync(int animalId)
        {
            return await projContext.Comments!.Where(c => c.AnimalId == animalId).ToListAsync();
        }
    }
}
