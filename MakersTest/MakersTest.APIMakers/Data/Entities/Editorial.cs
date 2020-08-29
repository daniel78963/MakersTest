
namespace MakersTest.APIMakers.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Editorial
    {
        [Key]
        public int IdEditorial { get; set; }

        [Required]
        public string Nombre { get; set; }
    }
}
