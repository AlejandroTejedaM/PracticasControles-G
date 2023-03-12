using CiberDLL;
using System.Windows.Forms;

namespace ComputadoraUserControl
{
    public partial class ComputadoraControl : UserControl
    {

        public Computadora Computadora { get; set; }

        public ComputadoraControl()
        {
            InitializeComponent();

        }

        public void Inicializar()
        {

            DateTime fecha = DateTime.Now;
            if (DateTime.Compare(Computadora.HoraInicio, fecha) >= 0)
            {
                Computadora.HoraInicio = Computadora.HoraFin;
                pbPC.Image = Image.FromFile(@"C:\TAP\PC_Apagada.png");
            }
            else
            {
                Computadora.HoraInicio = fecha;
                pbPC.Image = Image.FromFile(@"C:\TAP\PC_Encendida.png");
                timer1.Enabled = true;
                pbTiempo.Maximum = Computadora.TiempoInicial;
                pbTiempo.Value = Computadora.Tiempo;
            }
            txtFin.Text = Computadora.HoraFin.ToLongTimeString();
            txtInicio.Text = Computadora.HoraInicio.ToLongTimeString();
            txtUsuario.Text = Computadora.Usuario;
            txtCosto.Text = Computadora.Costo.ToString();
        }


        //public void ActualizarArchivo()
        //{
        //    Escritura esc = new Escritura(@"C:\TAP\Ciber.txt");
        //    foreach (var item in FlowLayoutPanel.Controls)
        //    {
        //        ComputadoraControl cc = item as ComputadoraControl;
        //        Computadora compu = cc.Computadora;
        //        esc.Escribir(compu.ToString());
        //    }
        //    esc.Cerrar();
        //}
        private void button1_Click(object sender, EventArgs e)
        {

            Computadora.TiempoInicial = int.Parse(txtTiempoExtra.Text);
            Computadora.HoraInicio = DateTime.Now;
            Computadora.HoraFin = DateTime.Now.AddSeconds(int.Parse(txtTiempoExtra.Text));
            if (DateTime.Compare(Computadora.HoraInicio, Computadora.HoraFin) >= 0)
            {
                Computadora.Tiempo = 0;
            }
            else
            {
                Computadora.Tiempo = Math.Abs(Convert.ToInt32((Computadora.HoraInicio - Computadora.HoraFin).TotalSeconds));
            }
            Inicializar();

        }

        private void ComputadoraControl_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (DateTime.Compare(Computadora.HoraInicio, Computadora.HoraFin) >= 0)
            {
                timer1.Stop();
                pbPC.Image = Image.FromFile(@"C:\TAP\PC_Apagada.png");
                txtInicio.Text = Computadora.HoraFin.ToLongTimeString();
            }
            else
            {
                Computadora.HoraInicio = DateTime.Now;
                txtInicio.Text = Computadora.HoraInicio.ToLongTimeString();
                if (pbTiempo.Value != 0)
                {
                    pbTiempo.Value--;
                }
                else
                {
                    pbTiempo.Value = 0;
                }
            }
        }
    }
}