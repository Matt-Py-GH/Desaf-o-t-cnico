using Aplicación_Desafío.Clases;

namespace Aplicación_Desafío
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductoDAL.ProductosMostrados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtIDTipo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Verificar que los campos numéricos tengan valores válidos
            int idTipoProducto;
            double precio;
            int cantidad;

            if (!int.TryParse(txtIDTipo.Text, out idTipoProducto))
            {
                MessageBox.Show("El ID del tipo de producto debe ser un número entero válido.");
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
                return;
            }

            Producto producto = new Producto();
            producto.IdTipoProducto = Convert.ToInt32(txtIDTipo.Text);
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToDouble(txtPrecio.Text);
            producto.Cantidad = Convert.ToInt32(txtCantidad.Text);

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProducto"].Value);
                producto.IdProducto = id;

                int resultado = ProductoDAL.ModificarProducto(producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto modificado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al modificar el producto.");
                }
                RefreshPantalla();
                
            }
            else
            {
                // Si no hay producto seleccionado, agregamos uno nuevo
                int resultado = ProductoDAL.AgregarProducto(producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto agregado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto.");
                }
                RefreshPantalla();

            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            campoID.Enabled = false;
            RefreshPantalla();
        }

        public void RefreshPantalla()
        {
            dataGridView1.DataSource = ProductoDAL.ProductosMostrados();
            campoID.Text = string.Empty;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Este software fue creado por: Mateo Miguel Delgado Ugarte");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Verifica si el campoID está vacío o no es un número válido
            if (string.IsNullOrWhiteSpace(campoID.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
                return; // Detiene la ejecución si el campo está vacío
            }

            // Verifica que el campo contenga un número entero válido
            int idProducto;
            if (!int.TryParse(campoID.Text, out idProducto))
            {
                MessageBox.Show("El ID del producto debe ser un número entero válido.");
                return;
            }

            Producto producto = new Producto();
            producto.IdProducto = idProducto;

            if (campoID.Text != null)
            {
                int resultado = ProductoDAL.EliminarProducto(producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Éxito al borrar producto");
                }
                else
                {
                    MessageBox.Show("Error al borrar producto");
                }
            }
            else
            {
                MessageBox.Show("Error, ningún producto seleccionado");
            }

            // Refresca la pantalla después de eliminar
            RefreshPantalla();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Producto producto = new Producto();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            campoID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["idProducto"].Value);
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            txtIDTipo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["idTipoProducto"].Value);
            txtPrecio.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Precio"].Value);
            txtCantidad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Cantidad"].Value);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
