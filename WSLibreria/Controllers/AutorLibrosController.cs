using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WSLibreria.Models;
using WSLibreria.DTO;

namespace WSLibreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorLibrosController : ControllerBase
    {
        private readonly IMapper _mapper;
        static List<Autores> lstAutores;
        string autoresRuta = @"C:\autores.json";

        public AutorLibrosController(IMapper mapper)
        {
            _mapper = mapper;
            if (lstAutores == null)
            {
                string autoresJson;
                using (var read = new StreamReader(autoresRuta))
                {
                    autoresJson = read.ReadToEnd();
                    lstAutores = JsonConvert.DeserializeObject<List<Autores>>(autoresJson);
                }
            }
            
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string nombre)
        {
            var autorDto = _mapper.Map<List<AutoresDTO>>(lstAutores)
                    .OrderBy(a => a.Nombre)
                    .Where(a => (nombre != null && a.Nombre.Contains(nombre)) || (nombre == null));
            return Ok(autorDto);
        }

        [HttpPost]
        public IActionResult Post(AutoresDTO autor)
        {
            var newAutor = _mapper.Map<AutoresDTO, Autores>(autor);
            lstAutores.Add(newAutor);
            var autorDto = _mapper.Map<List<AutoresDTO>>(lstAutores);
            return Ok(autorDto);
        }


    }
}
