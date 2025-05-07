using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using pryMBergagnaConexionBD;

namespace pryGestionInventario
{
    internal class clsConexionBD
    {
        private readonly string cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

        // Mostrar productos con nombre de la categoría
        public void Mostrar(DataGridView grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = @"SELECT P.Codigo, P.Nombre, P.Descripcion, P.Precio, P.Stock, C.Nombre AS Categoria
                                        FROM Productos P
                                        INNER JOIN Categorias C ON P.CategoriaId = C.Id";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    grilla.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.Message);
            }
        }

        // Cargar categorías en ComboBox
        public void CargarCategorias(ComboBox combo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT Id, Nombre FROM Categorias";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector = comando.ExecuteReader();

                    DataTable tabla = new DataTable();
                    tabla.Load(lector);

                    combo.DataSource = tabla;
                    combo.DisplayMember = "Nombre"; // Lo visible
                    combo.ValueMember = "Id";       // El verdadero valor
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        // Agregar producto
        public void AgregarProducto(string nombre, string descripcion, decimal precio, int stock, int categoriaId)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) VALUES (@nombre, @desc, @precio, @stock, @categoria)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@desc", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@categoria", categoriaId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        // Buscar producto por código
        public DataRow BuscarProducto(int codigo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Productos WHERE Codigo = @codigo";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    if (tabla.Rows.Count > 0)
                        return tabla.Rows[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar producto: " + ex.Message);
                return null;
            }
        }

        // Modificar producto
        public void ModificarProducto(int codigo, string nombre, string descripcion, decimal precio, int stock, int categoriaId)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = @"UPDATE Productos SET 
                                     Nombre = @nombre, 
                                     Descripcion = @desc, 
                                     Precio = @precio, 
                                     Stock = @stock, 
                                     CategoriaId = @categoria 
                                     WHERE Codigo = @codigo";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@desc", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@categoria", categoriaId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto modificado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar producto: " + ex.Message);
            }
        }

        // Eliminar producto
        public void EliminarProducto(int codigo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "DELETE FROM Productos WHERE Codigo = @codigo";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto eliminado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
        }
        public bool ProductoExiste(int codigo)
        {
            bool existe = false;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM Productos WHERE Codigo = @Codigo";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Codigo", codigo);

                int resultado = (int)comando.ExecuteScalar();

                if (resultado > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }
        public bool VerificarAdministradores(clsAdm admin)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Clave = @contraseña";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@usuario", admin.Usuario);
                    comando.Parameters.AddWithValue("@contraseña", admin.Passw);

                    int resultado = (int)comando.ExecuteScalar();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar administrador: " + ex.Message);
                return false;
            }
        }

    }
}
