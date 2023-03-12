using AppCiber;
using CiberDLL;

namespace ProductoUserControl
{
    public partial class ProductoControl : UserControl
    {
        public Producto ProductoInfo { get; set; }

        public event EventHandler btnActualizarClick;

        public event EventHandler btnSeleccionarClick;
        public ProductoControl()
        {
            InitializeComponent();
        }

        //LENAR LAS ETIQUETAS E IMAGEN DEL COMPONENTE
        public void Asignar(Producto p)
        {
            txtNombre.Text = p.Nombre;
            txtPrecio.Text = p.Precio.ToString();
            txtStock.Text = p.Stock.ToString();
            pbProducto.Image =
                Image.FromFile(p.Imagen);
            ProductoInfo = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnActualizarClick != null)
            {
                //le enviamos todo el control 
                //ya que el sender equivale solo al boton
                //de esta forma accedemos a todas las propiedades
                btnActualizarClick(this, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnSeleccionarClick != null)
            {
                //le enviamos todo el control 
                //ya que el sender equivale solo al boton
                //de esta forma accedemos a todas las propiedades
                btnSeleccionarClick(this, e);
            }
        }
    }
}