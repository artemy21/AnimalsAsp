using MediatR;
using LibCore.Repositories;
using LibApplication.Commands;

namespace LibApplication.Handlers.AnimalHandlers
{
    public class UpdateAnimalHandler : IRequestHandler<UpdateAnimalCommand, bool>
    {
        private readonly IAnimalRepository animalRepository;

        public UpdateAnimalHandler(IAnimalRepository animalRepository) => this.animalRepository = animalRepository;

        public async Task<bool> Handle(UpdateAnimalCommand request, CancellationToken cancellationToken)
        {
            await animalRepository.UpdateAsync(request.Animal!);
            return true;
        }
    }
}
