using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
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
        Thread hiloComprabador;
        Thread hiloPuntu;
        int xform;
        int yform;
        int x = 5;
        int y = 5;
        int xVelocidad = 5;
        int yVelocidad = 5;
        int velocidadInicial = 10;
        int velocidadMaxima = 10;
        int distanciaDesdeCentro;
        double anguloRebote;
        int Puntuacion = 0;
        double velocidadActual;
        bool enContactoConBarra = false;
        int auxTamPos = 0;
        int tamanio = 70;
        public frmEjercicio1()
        {
            InitializeComponent();
            AgregarBloques();
            Puntuacion = 0;
            txtPuntaje.Text = Puntuacion.ToString();
            hilo = new Thread(MetodoProfe);
            hilo.Start();
            #region MyCode
            //xform = this.Width;
            //yform = this.Height;

            //velocidadActual = Math.Sqrt(Math.Pow(xVelocidad, 2) + Math.Pow(yVelocidad, 2));
            //if (velocidadActual < velocidadInicial)
            //{
            //    xVelocidad = (int)(xVelocidad * velocidadMaxima / velocidadActual);
            //    yVelocidad = (int)(yVelocidad * velocidadMaxima / velocidadActual);
            //}
            #endregion

        }
        #region MyCode
        private void ComprobarColisiones()
        {
            while (true)
            {
                if (Pelota.Bounds.IntersectsWith(Barra.Bounds))
                {
                    if (!enContactoConBarra)
                    {
                        Rebote();
                        enContactoConBarra = true;
                        //xVelocidad = -xVelocidad;
                        //yVelocidad = -yVelocidad;
                    }
                }
                else
                {
                    enContactoConBarra = false;
                }
                if (x + Pelota.Width >= xform || x <= 0)
                {
                    xVelocidad = -xVelocidad;
                }

                if (y <= 0)
                {
                    yVelocidad = -yVelocidad;
                }

                if (y + Pelota.Height >= yform)
                {
                    MessageBox.Show("Pi pi pi pi pi...... tan tan");
                    Environment.Exit(0);
                }
                Thread.Sleep(30);
            }
        }
        private void Movimiento()
        {
            if (x <= 0 && y <= 0) // Verificar si la pelota está en la esquina superior izquierda
            {
                xVelocidad = +velocidadInicial + 1; // Cambiar la dirección horizontal
                yVelocidad = +velocidadInicial + 1; // Cambiar la dirección vertical
            }

            while (true)
            {
                Llamar_Delegado(x, y, Puntuacion);
                x += xVelocidad;
                y += yVelocidad;
                Thread.Sleep(50);

                if (Pelota.Bounds.IntersectsWith(Barra.Bounds))
                {
                    if (!enContactoConBarra)
                    {
                        Rebote();
                        enContactoConBarra = true;
                        //xVelocidad = -xVelocidad;
                        //yVelocidad = -yVelocidad;
                    }
                    else
                    {
                        enContactoConBarra = false;
                    }
                }
                if (x + Pelota.Width >= xform || x <= 0)
                {
                    xVelocidad = -xVelocidad;
                }

                if (y <= 0)
                {
                    yVelocidad = -yVelocidad;
                }

                if (y + Pelota.Height >= yform)
                {
                    MessageBox.Show("Perdiste el juego");
                    Environment.Exit(0);
                }
            }
        }
        private void Rebote()
        {
            //Calcula la posicion de
            distanciaDesdeCentro = Pelota.Location.X + Pelota.Width / 2 - Barra.Location.X - Barra.Width / 2;

            // Calcular el ángulo de rebote en función de la posición de la barra en la que se ha producido la colisión
            anguloRebote = distanciaDesdeCentro * Math.PI / Barra.Width;

            // Cambiar la dirección de la pelota en función del ángulo de rebote
            xVelocidad = (int)(Math.Sin(anguloRebote) * velocidadInicial);
            yVelocidad = -1 * (int)(Math.Cos(anguloRebote) * velocidadInicial);

            velocidadActual = Math.Sqrt(Math.Pow(xVelocidad, 2) + Math.Pow(yVelocidad, 2));
            if (velocidadActual < velocidadInicial)
            {
                xVelocidad = (int)(xVelocidad * velocidadMaxima / velocidadActual);
                yVelocidad = (int)(yVelocidad * velocidadMaxima / velocidadActual);
            }

        }
        #endregion

        #region Delegados
        private delegate void delegado_mover(int x, int y, int puntaje);
        private delegate void delegado_Puntuacion(int x);
        private void Llamar_Delegado(int x, int y, int puntaje)
        {
            if (InvokeRequired)
            {
                delegado_mover dm = new delegado_mover(Llamar_Delegado);
                object[] p = new object[] { x, y, puntaje };
                Invoke(dm, p);
            }
            else
            {
                Pelota.Location = new Point(x, y);
                //txtPuntaje.Text = puntaje.ToString();
            }
        }
        private void LLamar_DelegadoPuntaje(int x)
        {
            if (InvokeRequired)
            {
                delegado_Puntuacion dm = new delegado_Puntuacion(LLamar_DelegadoPuntaje);
                object[] p = new object[] { x };
                Invoke(dm, p);
            }
            else
            {
                txtPuntaje.Text = x.ToString();
            }
        }
        #endregion
        private void AgregarBloques()
        {
            int tamaniox = 155;
            int tamanioy = 25;
            int posx = 10;
            int posy = 10;

            for (int i = 1; i <= 16; i++)
            {
                PictureBox picture = new PictureBox();
                picture.BorderStyle = BorderStyle.Fixed3D;
                Block block = new Block();
                block.Tipo = "bloque";
                int a = new Random().Next(1, 4);
                switch (a)
                {
                    case 1:
                        block.Puntos = 1;
                        block.Color = Color.Blue;
                        break;

                    case 2:
                        block.Puntos = 2;
                        block.Color = Color.Orange;
                        break;
                    case 3:
                        block.Puntos = 3;
                        block.Color = Color.Red;
                        break;

                    default:
                        block.Puntos = 0;
                        block.Color = Color.Black;
                        break;

                }
                picture.Size = new Size(tamaniox, tamanioy);
                picture.Location = new Point(posx, posy);
                picture.BackColor = block.Color;
                picture.Tag = block;
                Controls.Add(picture);
                posx += tamaniox + 10;
                if (i % 4 == 0)
                {
                    posy += tamanioy + 10;
                    posx = 10;
                }
            }
        }

        public void MetodoProfe()
        {
            Random r = new Random();
            int x = 353;
            int y = 200;
            int ax = 5;
            int ay = 5;
            int dificultad = 50;
            bool subir = false;
            bool derecha = false;
            bool chocado1 = false;
            bool chocado2 = false;
            bool chocado3 = false;
            bool chocado4 = false;

            while (true)
            {
                Llamar_Delegado(x, y, Puntuacion);
                if (subir == false)
                {
                    y += ay;
                    if (Pelota.Bounds.IntersectsWith(Barra.Bounds))
                    {
                        subir = !subir;
                        ay = r.Next(5, 15);
                        dificultad -= 00001;
                    }

                    if (Puntuacion == 250)
                    {
                        MessageBox.Show("GANASTE");
                        Environment.Exit(0);
                    }

                    if (Pelota.Location.Y + Pelota.Height >= this.Height)
                    {
                        MessageBox.Show("Tan tan");
                        Environment.Exit(0);
                    }
                }
                if (subir)
                {
                    y -= ay;
                    if (Pelota.Location.Y <= 0)
                    {
                        subir = !subir;
                        ay = r.Next(5, 15);
                    }
                    if (Puntuacion == 250)
                    {
                        MessageBox.Show("GANASTE");
                        Environment.Exit(0);
                    }
                }
                if (derecha)
                {
                    x += ax;
                    if (Pelota.Location.X + Pelota.Width >= this.Width)
                    {
                        derecha = !derecha;
                        ax = r.Next(5, 15);
                    }
                }
                if (!derecha)
                {
                    x -= ax;
                    if (Pelota.Location.X <= 0)
                    {
                        derecha = !derecha;
                        ax = r.Next(5, 15);
                    }
                }
                foreach (Control c in Controls)
                {
                    if (c is PictureBox)
                    {
                        if (c.Tag is Block)
                        {
                            Block block = c.Tag as Block;
                            if (Pelota.Bounds.IntersectsWith(c.Bounds))
                            {
                                c.Dispose();
                                if (block.Color == Color.Blue)
                                {
                                    Puntuacion += block.Puntos;
                                    LLamar_DelegadoPuntaje(Puntuacion);
                                }
                                if (block.Color == Color.Orange)
                                {
                                    Puntuacion += block.Puntos;
                                    LLamar_DelegadoPuntaje(Puntuacion);
                                }
                                if (block.Color == Color.Red)
                                {
                                    Puntuacion += block.Puntos;
                                    LLamar_DelegadoPuntaje(Puntuacion);
                                }
                                if (block.Color == Color.Black)
                                {
                                    Puntuacion += block.Puntos;
                                    LLamar_DelegadoPuntaje(Puntuacion);
                                }
                            }
                        }
                    }
                }
                Thread.Sleep(50);
            }
        }
      
        private void frmEjercicio1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Barra.Location = new Point(Barra.Location.X - 20, Barra.Location.Y);
            }
            if (e.KeyCode == Keys.Right)
            {
                Barra.Location = new Point(Barra.Location.X + 20, Barra.Location.Y);
            }
        }
        private void frmEjercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void frmEjercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}


