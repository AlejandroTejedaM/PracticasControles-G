using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHilos.Ejercicio1
{
    public partial class frmEjercicio1 : Form
    {
        Thread hilo;
        public frmEjercicio1()
        {
            InitializeComponent();
            hilo = new Thread(Movimiento);
            hilo.Start();
        }

        private delegate void delegado_mover(int x, int y);

        private void Llamar_Delegado(int x, int y)
        {
            if (InvokeRequired)
            {
                delegado_mover dm = new delegado_mover(Llamar_Delegado);
                object[] p = new object[] { x, y };
                Invoke(dm, p);
            }
            else
            {
                pictureBox1.Location = new Point(x, y);
            }
        }

        private void Movimiento()
        {
            int x = 0;
            int y = 0;
            //para que se ejecute el movimiento de manera indefinida
            while (true)
            {
                Llamar_Delegado(x, y);
                x += 5;
                y += 5;
                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    x = pictureBox1.Location.X;
                    y = pictureBox1.Location.Y;

                    Thread.Sleep(100);
                }
            }
        }
        private void frmEjercicio1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y);
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
            }
        }

        private void frmEjercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


