using CiberDLL;
using ComputadoraUserControl;

namespace AppCiber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private ComputadoraControl GetComputadoraControl(Computadora c)
        {
            ComputadoraControl cc = new ComputadoraControl();
            cc.Computadora = c;
            cc.Inicializar();
            
            return cc;
        }


        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Computadora c = new Computadora
            {
                Costo = decimal.Parse(txtCosto.Text),
                Usuario = txtUsuario.Text,
                HoraInicio = DateTime.Now,
                HoraFin = DateTime.Now.AddSeconds(int.Parse(txtTiempo.Text)),
                Tiempo = Math.Abs(Convert.ToInt32((DateTime.Now.AddSeconds(int.Parse(txtTiempo.Text)) - DateTime.Now).TotalSeconds)),
                TiempoInicial = int.Parse(txtTiempo.Text)
            };
            

            flowLayoutPanel1.Controls.Add(GetComputadoraControl(c));
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Escritura esc = new Escritura(@"C:\TAP\Ciber.txt");
            foreach (var item in flowLayoutPanel1.Controls)
            {
                ComputadoraControl cc = item as ComputadoraControl;
                Computadora compu = cc.Computadora;
                esc.Escribir(compu.ToString());
            }
            esc.Cerrar();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Lectura lec = new Lectura(@"C:\TAP\Ciber.txt");
            foreach (var item in lec.LeerPorLinea())
            {
                string[] linea = item.Split(",");
                Computadora compu = new Computadora
                {
                    Costo = decimal.Parse(linea[3]),
                    HoraFin = DateTime.Parse(linea[2]),
                    HoraInicio = DateTime.Parse(linea[1]),
                    Usuario = linea[0],
                    TiempoInicial = int.Parse(linea[4]),
                };
                if (compu.HoraInicio >= compu.HoraFin)
                {
                    compu.Tiempo = 0;
                }
                else {
                    compu.Tiempo = Math.Abs(Convert.ToInt32((DateTime.Parse(linea[1]) - DateTime.Parse(linea[2])).TotalSeconds));
                }
                flowLayoutPanel1.Controls.Add(GetComputadoraControl(compu));
            }
            lec.Cerrar();
        }
    }
}