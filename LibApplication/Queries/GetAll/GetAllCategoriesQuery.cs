using MediatR;
using LibCore.Models;

namespace LibApplication.Queries.GetAll
{
    public class GetAllCategoriesQuery : IRequest<List<Category>?>
    {
    }
}
