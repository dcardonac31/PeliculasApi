using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeliculasApi.DTOs;
using PeliculasApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasApi.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController: CustomBaseController
    {

        public GenerosController(ApplicationDbContext context, IMapper mapper)
            :base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<GeneroDto>>> Get()
        {
            return await Get<Genero, GeneroDto>();
        }


        [HttpGet("{id:int}", Name = "getGenero")]
        public async Task<ActionResult<GeneroDto>> Get(int id)
        {
            return await Get<Genero, GeneroDto>(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GeneroCreacionDto generoCreacionDTO)
        {
            return await Post<GeneroCreacionDto, Genero, GeneroDto>(generoCreacionDTO, "getGenero");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] GeneroCreacionDto generoCreacionDTO)
        {
            return await Put<GeneroCreacionDto, Genero>(id, generoCreacionDTO);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await Delete<Genero>(id);
        }

    }
}
