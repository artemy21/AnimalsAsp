using MediatR;
using LibCore.Models;

namespace LibApplication.Queries.GetAll
{
    public class GetAllCommentsQuery : IRequest<List<Comment>?>
    {
        public int AnimalId { get; }

        public GetAllCommentsQuery(int animalId) => AnimalId = animalId;
    }
}
