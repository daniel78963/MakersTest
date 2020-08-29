using MakersTest.APIMakers.Data.Entities;
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
    }
}
