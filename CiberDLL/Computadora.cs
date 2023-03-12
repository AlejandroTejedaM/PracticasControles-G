using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberDLL
{
    public class Computadora
    {
        //public int Numero { get; set; }
        public string Usuario { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public decimal Costo { get; set; }
        public int Tiempo { get; set; }
        public int TiempoInicial { get; set; }
        public override string ToString()
        {
            return $"{Usuario},{HoraInicio},{HoraFin},{Costo},{TiempoInicial}";
        }
    }
}
