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
    public class GenerosController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenerosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GeneroDto>>> Get()
        {
            var entities = await context.Generos.ToListAsync();
            var dtos = mapper.Map<List<GeneroDto>>(entities);
            return dtos;
        }


        [HttpGet("{id:int}", Name = "getGenero")]
        public async Task<ActionResult<GeneroDto>> Get(int id)
        {
            var entitie = await context.Generos.FirstOrDefaultAsync(x => x.Id == id);

            if(entitie == null)
            {
                return NotFound();
            }

            var dto = mapper.Map<GeneroDto>(entitie);

            return dto;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GeneroCreacionDto generoCreacionDTO)
        {
            var entidad = mapper.Map<Genero>(generoCreacionDTO);
            context.Add(entidad);
            await context.SaveChangesAsync();
            var generoDTO = mapper.Map<GeneroDto>(entidad);

            return new CreatedAtRouteResult("getGenero", new { id = generoDTO.Id }, generoDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] GeneroCreacionDto generoCreacionDTO)
        {
            var entitie = mapper.Map<Genero>(generoCreacionDTO);
            entitie.Id = id;
            context.Entry(entitie).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await context.Generos.AnyAsync(x => x.Id == id);

            if(!exists)
            {
                return NotFound();
            }

            context.Remove(new Genero() { Id = id });
            await context.SaveChangesAsync();

            return NoContent();
        }

    }
}
