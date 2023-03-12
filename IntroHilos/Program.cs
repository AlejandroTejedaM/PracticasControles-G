using IntroHilos;
using System.Threading;

//importamos System.Threading para manejar varios procesos
Hilo hilo = new Hilo();
Thread miHilo = new Thread(hilo.ImprimirX);
Thread miHilo2 = new Thread(hilo.ImprimirY);
miHilo.Start();

for (int i = 0; i < 1000; i++)
{
    Console.Write("Z");
}
miHilo2.Start();
