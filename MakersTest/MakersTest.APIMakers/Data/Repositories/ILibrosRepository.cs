using MakersTest.APIMakers.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakersTest.APIMakers.Data.Repositories
{
    public interface ILibrosRepository
    {
        IEnumerable<Libro> GetAll();

        Task<Libro> GetByIdAsync(int id);

        Task<Libro> CreateAsync(Libro libro);

        Task<Libro> UpdateAsync(Libro libro);

        Task DeleteAsync(Libro libro);

        Task<bool> SaveAllAsync();
    }
}
