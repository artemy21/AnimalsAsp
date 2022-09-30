using MediatR;
using LibCore.Repositories;
using LibApplication.Commands;

namespace LibApplication.Handlers.AnimalHandlers
{
    public class DeleteAnimalHandler : IRequestHandler<DeleteAnimalCommand, bool>
    {
        private readonly IAnimalRepository animalRepository;

        public DeleteAnimalHandler(IAnimalRepository animalRepository) => this.animalRepository = animalRepository;

        public async Task<bool> Handle(DeleteAnimalCommand request, CancellationToken cancellationToken)
        {
            await animalRepository.DeleteAsync(request.Animal!);
            return true;
        }
    }
}
