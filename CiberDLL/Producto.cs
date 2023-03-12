using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCiber
{   //internal es publico para el namespace pero privado para otros
    public class Producto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set;}
        public int Stock { get; set;}
        public decimal Precio { get; set; }
        public string Imagen { get; set; }

    }
}
