using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasApi.DTOs
{
    public class GeneroDto: GeneroCreacionDto
    {
        public int Id { get; set; }

    }
}
