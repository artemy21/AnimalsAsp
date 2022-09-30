using MediatR;
using LibCore.Models;

namespace LibApplication.Queries.GetAll
{
    public class GetAllAnimalsQuery : IRequest<List<Animal>?>
    {
    }
}
