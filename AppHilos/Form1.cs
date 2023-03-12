using System.Drawing.Text;
using System.Threading;
namespace AppHilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
        }

        #region Delegados
        //Paso 1: declarar el delegado
        private delegate void delegado_lista(int v);
        //Paso 2: invocar el delegado
        private void InvocarDelegado(int v)
        {
            //cuando lo invocamos por primera vez se debe instanciar
            if (InvokeRequired)
            {
                delegado_lista agregar = new delegado_lista(InvocarDelegado);
                object[] param = new object[] { v };
                Invoke(agregar, param);
            }
            else
            {
                listBox1.Items.Add(v);
            }
        }
        //Paso 3: Crear un metodo que invoque al delegado
        private void CicloFor()
        {
            for (int i = 0; i < 100; i++)
            {
                InvocarDelegado(i);
                Thread.Sleep(100);
            }
            MessageBox.Show("He finalizado");
        }
        //Paso 4: Invocar Hilo
        private void button1_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(CicloFor);
            hilo.Start();
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
        //10 - roman
        //jueves - conferencia
        //miercoles - posible entrada a 1 tarde

        //FileSystemWatcher 
        //para detectr en tiempo real cambios en algo
    }
}