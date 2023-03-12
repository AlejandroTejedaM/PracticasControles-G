using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberDLL
{
    public class Lectura 
    {
        StreamReader lectura;
        public Lectura(string ruta)
        {
            lectura = new StreamReader(ruta);
        }

        public string LeerTodo()
        {
            return lectura.ReadToEnd();
        }

        public List<string> LeerPorLinea()
        {
            List<string> lineas = new List<string>();
            string linea = "";
            while((linea = lectura.ReadLine()!) != null)
            {
                lineas.Add(linea);
            }
            return lineas;
        }

        public void Cerrar()
        {
            lectura.Close();
        }

        
    }
}
