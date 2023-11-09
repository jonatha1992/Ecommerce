﻿using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using React_Net;
using React_Net.Models;

namespace AspNetCore.Controllers
{
    [ApiController]
    [Route("api/peliculas")]
    public class PeliculasController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PeliculasController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pelicula>> Get(int id)
        {
            var pelicula = await context.Peliculas
                .Include(p => p.Comentarios)
                .Include(p => p.Generos)
                .Include(p => p.Personajes.OrderBy(pa => pa.Orden))
                    .ThenInclude(pa => pa.Actor)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (pelicula is null)
            {
                return NotFound();
            }

            return pelicula;
        }

        [HttpGet("select/{id:int}")]
        public async Task<ActionResult> GetSelect(int id)
        {
            var pelicula = await context.Peliculas
                .Select(pel => new
                {
                    pel.Id,
                    pel.Titulo,
                    Generos = pel.Generos.Select(g => g.Nombre).ToList(),
                    Actores = pel.Personajes.OrderBy(pa => pa.Orden).Select(pa =>
                    new {
                        Id = pa.Actor.Id,
                        NombreActor= pa.Actor.Nombre,
                        NombrePersonaje = pa.Nombre
                    }),
                    CantidadComentarios = pel.Comentarios.Count()
                })
                .FirstOrDefaultAsync(p => p.Id == id);

            if (pelicula is null)
            {
                return NotFound();
            }

            return Ok(pelicula);
        }

        [HttpPost]
        public async Task<ActionResult> Post(PeliculaCreacionDTO peliculaCreacionDTO)
        {
            var pelicula = mapper.Map<Pelicula>(peliculaCreacionDTO);

            if (pelicula.Generos is not null)
            {
                foreach (var genero in pelicula.Generos)
                {
                    context.Entry(genero).State = EntityState.Unchanged;
                }
            }

            if (pelicula.Personajes is not null)
            {
                for (int i = 0; i < pelicula.Personajes.Count; i++)
                {
                    pelicula.Personajes[i].Orden = i + 1;
                }
            }

            context.Add(pelicula);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}/moderna")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAlteradas = await context.Peliculas
                .Where(g => g.Id == id).ExecuteDeleteAsync();

            if (filasAlteradas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
