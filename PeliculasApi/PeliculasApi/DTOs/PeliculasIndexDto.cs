using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasApi.DTOs
{
    public class PeliculasIndexDto
    {
        public List<PeliculaDto> FuturosEstrenos { get; set; }
        public List<PeliculaDto> EnCines { get; set; }

    }
}
