using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController() { }

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular",
                Local = "SP",
                Lote = "1º Lote",
                QtdPessoas = 100,
                DataEvento = DateTime.Now.AddDays(2).ToString()
            },
             new Evento() {
                EventoId = 2,
                Tema = "C#",
                Local = "SP",
                Lote = "1º Lote",
                QtdPessoas = 100,
                DataEvento = DateTime.Now.AddDays(3).ToString()
            }
        };

        // [HttpGet]
        // public Evento Get()
        // {
        //     return new Evento() {
        //         EventoId = 1,
        //         Tema = "Angular",
        //         Local = "SP",
        //         Lote = "1º Lote",
        //         QtdPessoas = 100,
        //         DataEvento = DateTime.Now.AddDays(2).ToString()
        //     };
        // }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "id";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "id";
        }
    }
}
