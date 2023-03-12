﻿using System;
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
        double velocidadActual;
        bool enContactoConBarra = false;
        public frmEjercicio1()
        {
            InitializeComponent();
            hilo = new Thread(Movimiento);
            hilo.Start();

            hiloComprabador = new Thread(ComprobarColisiones);
            hiloComprabador.Start();

            xform = this.ClientSize.Width;
            yform = this.ClientSize.Height;

            velocidadActual = Math.Sqrt(Math.Pow(xVelocidad, 2) + Math.Pow(yVelocidad, 2));
            if (velocidadActual < velocidadInicial)
            {
                xVelocidad = (int)(xVelocidad * velocidadMaxima / velocidadActual);
                yVelocidad = (int)(yVelocidad * velocidadMaxima / velocidadActual);

                //xVelocidad = (int)(xVelocidad / velocidadActual);
                //yVelocidad = (int)(yVelocidad / velocidadActual);
            }
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
                Pelota.Location = new Point(x, y);
            }
        }
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
                    MessageBox.Show("Perdiste el juego");
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
                Llamar_Delegado(x, y);
                x += xVelocidad;
                y += yVelocidad;
                Thread.Sleep(50);
            }
        }
        private void Rebote()
        {

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

                //xVelocidad = (int)(xVelocidad / velocidadActual);
                //yVelocidad = (int)(yVelocidad / velocidadActual);
            }
        }
        private void frmEjercicio1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Barra.Location = new Point(Barra.Location.X - 10, Barra.Location.Y);
            }
            if (e.KeyCode == Keys.Right)
            {
                Barra.Location = new Point(Barra.Location.X + 10, Barra.Location.Y);
            }
        }

        private void frmEjercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


