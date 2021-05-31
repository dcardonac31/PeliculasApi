using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasApi.DTOs
{
    public class GeneroCreacionDto
    {
        [Required]
        [MaxLength(40)]
        public string Nombre { get; set; }
    }
}
