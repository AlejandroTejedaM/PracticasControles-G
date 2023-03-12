namespace CiberDLL
{
    public class Escritura
    {
        StreamWriter escritura;
        public Escritura(string ruta, bool append = false)
        {
            escritura = new StreamWriter(ruta, append);
        }

        public void Escribir(string texto)
        {
            escritura.WriteLine(texto);
        }

        public void Cerrar()
        {
            escritura.Close();
        }
    }
}