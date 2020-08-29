using MakersTest.APIMakers.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakersTest.APIMakers.Data.Repositories
{
    public class LibrosRepository : ILibrosRepository
    {
        private readonly DataContext context;

        public LibrosRepository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Libro> GetAll()
        {
            return context.Libros;
        }

        public async Task<Libro> GetByIdAsync(int id)
        {
            return await this.context.Libros
                .FirstOrDefaultAsync();
        }

        public async Task<Libro> CreateAsync(Libro libro)
        {
            await this.context.Libros.AddAsync(libro);
            await SaveAllAsync();
            return libro;
        }

        public async Task<Libro> UpdateAsync(Libro libro)
        {
            this.context.Libros.Update(libro);
            await SaveAllAsync();
            return libro;
        }

        public async Task DeleteAsync(Libro libro)
        {
            this.context.Libros.Remove(libro);
            await SaveAllAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }
    }
}
