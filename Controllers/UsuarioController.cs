using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private DataContext _context;
        public UsuarioController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Usuario>>> Get([FromServices] DataContext context)
        {
            var categories = await context.Usuarios.ToListAsync();
            return categories;
        }
        [HttpPost]
        [Route("/save")]
        public IActionResult Post()
        {
            // if(ModelState.IsValid)
            // {
            //     context.Usuarios.Add(model);
            //     await context.SaveChangesAsync();
            //     return model;
            // }
            // else
            // {
            //     return BadRequest(ModelState);
            // }
            return Ok();
        }
    }
}

