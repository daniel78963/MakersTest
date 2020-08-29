
namespace MakersTest.API.Data
{
    using MakersTest.API.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Internal;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DataContext : DbContext
    {
        public DbSet<Editorial> Editorials { get; set; }
        public DbSet<Libro> Libros { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
