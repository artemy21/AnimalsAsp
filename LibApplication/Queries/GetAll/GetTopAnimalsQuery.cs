using MediatR;
using LibCore.Models;

namespace LibApplication.Queries.GetAll
{
	public class GetTopAnimalsQuery : IRequest<List<Animal>?>
    {
		public int Count { get; set; } = 2;

		public GetTopAnimalsQuery(int count) => Count = count;
	}
}
