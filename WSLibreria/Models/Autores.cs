using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSLibreria.Models
{
    public class Autores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string PaisOrigen { get; set; }
        public List<Libros> lstLibros { get; set; }
    }
}
