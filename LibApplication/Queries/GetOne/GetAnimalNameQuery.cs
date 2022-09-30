using MediatR;
using LibCore.Models;

namespace LibApplication.Queries.GetOne
{
    public class GetAnimalNameQuery : IRequest<Animal>
    {
        public string AnimalName { get; }

        public GetAnimalNameQuery(string animalName) => AnimalName = animalName;
    }
}
