using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using React_Net;
using React_Net.Models;

namespace AspNetCore.Controllers
{
    [ApiController]
    [Route("api/peliculas/{peliculaId:int}/comentarios")]
    public class ComentariosController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ComentariosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(int peliculaId, 
            ComentarioCreacionDTO comentarioCreacionDTO)
        {
            var comentario = mapper.Map<Comentario>(comentarioCreacionDTO);
            //comentario.Pelicula.Id = peliculaId;
            comentario.Pelicula = new Pelicula(peliculaId);
            context.Add(comentario);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
