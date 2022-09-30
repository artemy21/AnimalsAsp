using MediatR;
using LibCore.Models;

namespace LibApplication.Commands
{
	public class UpdateAnimalCommand : IRequest<bool>
    {
		public Animal? Animal { get; set; }

		public UpdateAnimalCommand(Animal? animal) => Animal = animal;
	}
}
