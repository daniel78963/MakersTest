 
namespace MakersTest.Unit.Test.MockRepository
{
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using Personalizados.Unit.Tests.Stubs;
    using Personalizados.Web.Data;
    using Personalizados.Web.Data.Entities;
    using Personalizados.Web.Models;
    using System.Threading.Tasks;

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
            librosRepository.Setup((x) => x.CreateAsync(LibrosStub.country1)); 
        }
    }
}
