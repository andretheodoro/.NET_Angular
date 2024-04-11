using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURSONETANDRE.API.Models;
using Microsoft.AspNetCore.Mvc;
using CURSONETANDRE.API.Data;
using Microsoft.Extensions.Logging;

namespace CURSONETANDRE.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Eventos> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Eventos Get(int id)
        {
            return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put Id: {id}";
        }
    }
}
