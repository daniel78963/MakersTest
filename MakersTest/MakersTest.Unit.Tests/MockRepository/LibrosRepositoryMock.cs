
namespace MakersTest.Unit.Tests.MockRepository
{
    using MakersTest.APIMakers.Data.Repositories;
    using MakersTest.Unit.Tests.Stubs;
    using Moq;

    public class LibrosRepositoryMock
    {
        public Mock<ILibrosRepository> librosRepository { get; set; }

        public LibrosRepositoryMock()
        {
            librosRepository = new Mock<ILibrosRepository>();
            Setup();
        }

        private void Setup()
        {
            librosRepository.Setup((x) => x.CreateAsync(LibrosStub.libro1));
        }
    }
}
