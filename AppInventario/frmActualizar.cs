using AppCiber;
using ProductoUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInventario
{
    public partial class frmActualizar : Form
    {
        ProductoControl producto;
        //Producto ProductoInfo;
        public frmActualizar(ProductoControl p)
        {
            InitializeComponent();
            producto = p;
            //producto.ProductoInfo = this.ProductoInfo;
            RefrescarDatos();
        }
        public void RefrescarDatos()
        {
            lblNombreProducto.Text = producto.ProductoInfo.Nombre;
            lblPrecio.Text = producto.ProductoInfo.Precio.ToString();
            lblStock.Text = producto.ProductoInfo.Stock.ToString();
            pbImagenProducto.Image = Image.FromFile(producto.ProductoInfo.Imagen);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            producto.ProductoInfo.Stock++;
            producto.Asignar(producto.ProductoInfo);
            RefrescarDatos();
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            //lblNombreProducto.Text = producto.ProductoInfo.Nombre;
            //lblPrecio.Text = producto.ProductoInfo.Precio.ToString();
            //lblStock.Text = producto.ProductoInfo.Stock.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            pbImagenProducto.Image = Image.FromFile(file);
            producto.ProductoInfo.Imagen = file;
            producto.Asignar(producto.ProductoInfo);
            RefrescarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            producto.ProductoInfo.Stock++;
            producto.Asignar(producto.ProductoInfo);
            RefrescarDatos();
        }

        private void btnCNombre_Click(object sender, EventArgs e)
        {
            producto.ProductoInfo.Nombre = txtNombre.Text;
            producto.Asignar(producto.ProductoInfo);
            RefrescarDatos();
        }

        private void btnDStock_Click(object sender, EventArgs e)
        {
            producto.ProductoInfo.Stock--;
            producto.Asignar(producto.ProductoInfo);
            RefrescarDatos();
        }

        private void btnAPrecio_Click(object sender, EventArgs e)
        {
            producto.ProductoInfo.Precio++;
            producto.Asignar(producto.ProductoInfo);
            RefrescarDatos();
        }

        private void btnDPrecio_Click(object sender, EventArgs e)
        {
            producto.ProductoInfo.Precio--;
            producto.Asignar(producto.ProductoInfo);
            RefrescarDatos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            producto.ProductoInfo.Stock = int.Parse(txtStock.Text);
            producto.Asignar(producto.ProductoInfo);
            RefrescarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            producto.ProductoInfo.Precio = int.Parse(txtPrecio.Text);
            producto.Asignar(producto.ProductoInfo);
            RefrescarDatos();
        }
    }
}
