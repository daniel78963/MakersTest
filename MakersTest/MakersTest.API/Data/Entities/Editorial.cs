
namespace MakersTest.API.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Editorial
    {
        [Key]
        public int IdEditorial { get; set; }

        [Required]
        public int Nombre { get; set; }
    }
}
