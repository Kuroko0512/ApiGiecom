using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApiGiecom.Models;

namespace ApiGiecom.Controllers
{
    [ApiController]
    [Route("ApiGiecom/[controller]")]
    public class PersonasController : Controller
    {
        private readonly GiecomContext _context;

        public PersonasController(GiecomContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Persona>> Index()
        {
            var personas = await _context.Personas.ToListAsync();
            return personas;
        }
    }
}
