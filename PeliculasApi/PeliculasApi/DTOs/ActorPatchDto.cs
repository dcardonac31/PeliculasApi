using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasApi.DTOs
{
    public class ActorPatchDto
    {
        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
    }
}
