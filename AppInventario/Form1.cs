using AppCiber;
using CiberDLL;
using ProductoUserControl;
namespace AppInventario
{
    public partial class Form1 : Form
    {
        List<Producto> listaProductos;
        public Form1()
        {
            InitializeComponent();
            listaProductos = new List<Producto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Descripcion = "SD",
                Id = Guid.NewGuid(),
                Imagen = "C:\\TAP\\Pepsi.png",
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
            };
            ProductoControl pc = new ProductoControl();
            pc.Asignar(p);
            pc.Tag = p;
            pc.btnActualizarClick += Pc_btnActualizarClick;
            pc.btnSeleccionarClick += Pc_btnSeleccionarClick;
            flowLayoutPanel1.Controls.Add(pc);
        }

        private void Pc_btnSeleccionarClick(object? sender, EventArgs e)
        {
            ProductoControl pc = sender as ProductoControl;
            frmSeleccionar frm = new frmSeleccionar(pc, listaProductos);
            frm.ShowDialog();
        }

        private void Pc_btnActualizarClick(object? sender, EventArgs e)
        {
            ProductoControl pc = sender as ProductoControl;
            frmActualizar frm = new frmActualizar(pc);
            //flowLayoutPanel1.Controls.Add(pc);
            frm.ShowDialog();
            //Poder actualizar todos los datos
            //hasta la imagen
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCarritoCompras frmCarritoCompras = new frmCarritoCompras(listaProductos);
            frmCarritoCompras.ShowDialog();
        }
    }
}