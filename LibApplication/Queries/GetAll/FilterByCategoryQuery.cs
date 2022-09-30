using MediatR;
using LibCore.Models;

namespace LibApplication.Queries.GetAll
{
	public class FilterByCategoryQuery : IRequest<List<Animal>?>
    {
		public int CategoryId { get; }

		public FilterByCategoryQuery(int categoryId) => CategoryId = categoryId;
	}
}
