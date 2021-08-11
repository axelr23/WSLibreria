using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSLibreria.Models
{
    public class Libros
    {
        public string Titulo { get; set; }
        public int AnoPublicacion { get; set; }
        public int NumeroPaginas { get; set; }
        public int CantidadInventario { get; set; }
        public int IdAutor { get; set; }
    }
}
