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
           
            if (string.IsNullOrWhiteSpace(txtIDTipo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Verifica que los campos numéricos tengan valores válidos
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

            // Si todas las validaciones son correctas, continúa con el proceso
            Producto producto = new Producto();
            producto.IdTipoproducto = idTipoProducto;
            producto.Nombre = txtNombre.Text;
            producto.Precio = precio;
            producto.Cantidad = cantidad;

            int resultado = ProductoDAL.AgregarProducto(producto);

            if (resultado > 0)
            {
                MessageBox.Show("Éxito al guardar");
            }
            else
            {
                MessageBox.Show("Error al guardar");
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
            Producto producto = new Producto();
            producto.IdProducto = Convert.ToInt32(campoID.Text);

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
