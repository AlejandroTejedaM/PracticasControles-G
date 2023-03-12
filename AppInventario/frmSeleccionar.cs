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
    public partial class frmSeleccionar : Form
    {
        ProductoControl control;
        List<Producto> productos;
        public frmSeleccionar(ProductoControl q, List<Producto> a)
        {
            InitializeComponent();
            control = q;
            productos = a;
            txtNombre.Text = control.ProductoInfo.Nombre;
            txtPrecio.Text = control.ProductoInfo.Precio.ToString();
            txtStock.Text = control.ProductoInfo.Stock.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int varAux = 0;
            //creamos unar variable auxiliar
            varAux = control.ProductoInfo.Stock;
            varAux -= int.Parse(txtCantidadCompraProd.Text);
            //siempre que la cantidad ingresada no sea mayor al stock disponible 
            //se agregaran productos comprados a la lista 
            if (varAux < 0)
            {
                MessageBox.Show("La cantidad ingresada excede el stock disponible");
            }
            else {
                Producto productoComprado = new Producto()
                {
                    Id = control.ProductoInfo.Id,
                    Descripcion = control.ProductoInfo.Descripcion,
                    Nombre = control.ProductoInfo.Nombre,
                    Imagen = control.ProductoInfo.Imagen,
                    Precio = control.ProductoInfo.Precio
                };
                productoComprado.Stock = varAux;
                control.ProductoInfo.Stock -= varAux;
                txtStock.Text = control.ProductoInfo.Stock.ToString();
                control.Asignar(control.ProductoInfo);
                productos.Add(productoComprado);
            }
        }
    }
}
