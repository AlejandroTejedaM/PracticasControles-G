using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroHilos
{
    internal class Hilo
    {
        public void ImprimirY() 
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Y");
            }
        }
        public void ImprimirX()     
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }
        }
    }
}
