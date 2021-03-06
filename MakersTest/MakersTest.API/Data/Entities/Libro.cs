﻿
namespace MakersTest.API.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Libro
    {
        [Key]
        public int IdLibro { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "El campo {0} solo permite máximo {1} caracteres de longitud.")]
        public string Titulo { get; set; }

        public DateTime Fecha { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Costo { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal PrecioSugerido { get; set; }

        public string Autor { get; set; }

        public Editorial Editorial { get; set; }
    }
}
