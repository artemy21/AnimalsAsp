using LibApplication.Commands;
using LibApplication.Handlers.AnimalHandlers;
using LibCore.Models;
using LibCore.Repositories;
using MediatR;
using Moq;

namespace LibApplicationTests.AnimalHandlerTest
{
    [TestClass]
    public class CreateAnimalHandlerTests
    {
        private Mock<IAnimalRepository> mockAnimalRepository;
        //private Mock<IRequestHandler<CreateAnimalCommand, Animal>> mockRequestHandler;

        public CreateAnimalHandlerTests()
        {
            mockAnimalRepository = new Mock<IAnimalRepository>();
            //mockRequestHandler = new Mock<IRequestHandler<CreateAnimalCommand, Animal>>();
        }

        [TestMethod]
        public async Task TestMethod1()
        {
            var animal = new Animal();
            mockAnimalRepository.Setup(x => x.AddAsync(animal)).ReturnsAsync(animal);


            CreateAnimalHandler animalHandler = new(mockAnimalRepository.Object);

            CreateAnimalCommand request = new()
            {
                Name = "animal1",
                Description = "desc",
                CategoryId = 1,
                ImageUrl = "https://www.google.com/"
            };
            CancellationToken cancellationToken = new();

            var animal1 = await animalHandler.Handle(request, cancellationToken);

            Assert.IsNotNull(animal1);
            //Assert.AreEqual(animal1.Name, "animal1");
            //Assert.AreEqual(animal.Description, "desc");
            //Assert.AreEqual(animal.Id, 1);
            //Assert.AreEqual(animal.CategoryId, 1);
        }
    }
}