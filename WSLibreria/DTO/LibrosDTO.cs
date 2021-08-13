using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSLibreria.DTO
{
    public class LibrosDTO
    {
        public string Titulo { get; set; }

        public int AnoPublicacion { get; set; }

        public int NumeroPaginas { get; set; }

        public int CantidadInventario { get; set; }

        public bool Existencia { get; set; }

        public int IdAutor { get; set; }
    }
}
