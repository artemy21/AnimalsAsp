using MediatR;
using LibCore.Models;

namespace LibApplication.Commands
{
	public class DeleteAnimalCommand : IRequest<bool>
    {
		public Animal? Animal { get; set; }
	}
}
