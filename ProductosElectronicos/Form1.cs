using System;
using System.Windows.Forms;

namespace ProductosElectronicos
{
    public partial class Form1 : Form
    {
        private Inventario inventario = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Intentando agregar producto..."); // Para depuración

            string nombre = txtNombreProducto.Text.Trim();

            if (decimal.TryParse(txtPrecioProducto.Text, out decimal precio) &&
                int.TryParse(txtCantidadStock.Text, out int stock) &&
                !string.IsNullOrWhiteSpace(nombre))
            {
                if (stock > 10)
                {
                    MessageBox.Show("No puedes agregar más de 10 productos en stock.");
                    return;
                }

                var producto = new ProductoElectronico(nombre, precio, stock);
                if (inventario.AgregarProducto(producto))
                {
                    Console.WriteLine("Producto agregado correctamente.");
                    MessageBox.Show("✅ Producto agregado de manera exitosa.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el producto.");
                }

                LimpiarCamposRegistro();
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos válidos.");
            }
        }

        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarProducto.Text.Trim();

            if (int.TryParse(txtCantidadVenta.Text, out int cantidad))
            {
                if (inventario.VenderProducto(nombre, cantidad))
                {
                    MessageBox.Show("Venta realizada con éxito.");
                }
                else
                {
                    MessageBox.Show("Stock insuficiente o producto no encontrado.");
                }
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
        }

        private void ActualizarLista()
        {
            listBoxInventario.Items.Clear();
            foreach (var producto in inventario.Productos)
            {
                listBoxInventario.Items.Add(producto.ToString());
            }
        }

        private void LimpiarCamposRegistro()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidadStock.Clear();
        }
    }
}
