using MediatR;
using LibCore.Models;

namespace LibApplication.Queries.GetOne
{
	public class GetAnimalIdQuery : IRequest<Animal>
	{
        public int AnimalId { get; }

		public GetAnimalIdQuery(int animalId) => AnimalId = animalId;
	}
}
