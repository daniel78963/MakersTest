
namespace MakersTest.APIMakers.Data
{
    using MakersTest.APIMakers.Data.Entities;
    using Microsoft.EntityFrameworkCore.Metadata.Conventions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class SeedDb
    {
        private readonly DataContext context;

        public SeedDb(DataContext context)
        {
            this.context = context;
        }

        public async Task SeedAsync()
        {
            //Hay que asegurarse de que la bases de datos ya esté creada. Recordar que es codefirst
            await context.Database.EnsureCreatedAsync();

            if (!context.Editorials.Any())
            {
                AddEditorial("AlfaOmega");
                AddEditorial("Babel");
                await context.SaveChangesAsync();
            }

            if (!context.Libros.Any())
            {
                AddLibro("Patrones", DateTime.Now.AddDays(-100), 20000, 20000, "Shaw T.");

                await context.SaveChangesAsync();
            }
        }

        private void AddEditorial(string nombre)
        {
            context.Editorials.Add(new Editorial
            {
                Nombre = nombre
            });
        }

        private void AddLibro(string titulo, DateTime fecha, decimal costo, decimal precio, string autor)
        {
            context.Libros.Add(new Libro
            {
                Titulo = titulo,
                Fecha = fecha,
                Costo = costo,
                PrecioSugerido = precio,
                Autor = autor
            });
        }
    }
}
