using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using pryGestionInventario;

namespace pryMBergagnaConexionBD
{
    public partial class Form1 : Form
    {
        clsConexionBD conexion = new clsConexionBD();
        clsConexionBD objConexionBD = new clsConexionBD();
        public Form1()
        {
            InitializeComponent();
            nudPrecio.Maximum = 10000000;
            nudPrecio.Minimum = 0;
            nudStock.Maximum = 10000;
            nudStock.Minimum = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Conexión establecida con la base de datos 'Comercio'", "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Mostrar(dgvProductos);
            conexion.CargarCategorias(cmbCategoria);
            dgvProductos.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDescripcion.Text == "" || nudPrecio.Text == "" || nudStock.Text == "" || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completá todos los campos.");
                return;
            }

            conexion.AgregarProducto(
                txtNombre.Text,
                txtDescripcion.Text,
                Convert.ToDecimal(nudPrecio.Text),
                Convert.ToInt32(nudStock.Text),
                Convert.ToInt32(cmbCategoria.SelectedValue)
            );

            conexion.Mostrar(dgvProductos);
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingresá un código válido.");
                return;
            }

            DataRow fila = conexion.BuscarProducto(codigo);

            if (fila != null)
            {
                txtNombre.Text = fila["Nombre"].ToString();
                txtDescripcion.Text = fila["Descripcion"].ToString();
                nudPrecio.Text = fila["Precio"].ToString();
                nudStock.Text = fila["Stock"].ToString();
                cmbCategoria.SelectedValue = fila["CategoriaId"];
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
                LimpiarCampos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingresá un código válido para modificar.");
                return;
            }

            conexion.ModificarProducto(
                codigo,
                txtNombre.Text,
                txtDescripcion.Text,
                Convert.ToDecimal(nudPrecio.Text),
                Convert.ToInt32(nudStock.Text),
                Convert.ToInt32(cmbCategoria.SelectedValue)
            );

            conexion.Mostrar(dgvProductos);
            LimpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingresá un código válido para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que querés eliminar el producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                conexion.EliminarProducto(codigo);
                conexion.Mostrar(dgvProductos);
                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Mostrar(dgvProductos);
            dgvProductos.ClearSelection();
            objConexionBD.Mostrar(dgvProductos); // Refrescar tabla
            LimpiarControles();              // Limpiar controles del grupo
        }

        // Método para limpiar campos
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            nudPrecio.Value = 0;
            nudStock.Value = 0;
            cmbCategoria.SelectedIndex = -1;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            clsConexionBD objConexion = new clsConexionBD();

            // Solo verificamos si el texto es un número válido
            if (int.TryParse(txtCodigo.Text, out int codigo))
            {
                if (objConexion.ProductoExiste(codigo))
                {
                    btnAgregar.Enabled = false;
                }
                else
                {
                    btnAgregar.Enabled = true;
                }
            }
            else
            {
                // Código inválido
                btnAgregar.Enabled = false;
            }
        }
        private void LimpiarControles()
        {
            // Recorre todos los controles dentro del GroupBox de detalles
            foreach (Control ctrl in gpbCargaDeDatos.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Value = 0;
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
            }

            // Si tenés alguna validación extra, también podés resetearla acá
            btnAgregar.Enabled = true; // Habilitás agregar por si estaba bloqueado
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                nudPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                nudStock.Value = Convert.ToInt32(fila.Cells["Stock"].Value);
                cmbCategoria.Text = fila.Cells["Categoria"].Value.ToString();
            }
        }
    }
}
