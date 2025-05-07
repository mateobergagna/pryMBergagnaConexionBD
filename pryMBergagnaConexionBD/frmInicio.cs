using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryGestionInventario;

namespace pryMBergagnaConexionBD
{
    public partial class frmInicio : Form
    {
        clsConexionBD conexion = new clsConexionBD();
        int intentosRestantes = 3;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsAdm admin = new clsAdm();
            admin.Usuario = txtUsuario.Text;
            admin.Passw = txtContraseña.Text;

            bool resultado = conexion.VerificarAdministradores(admin);
            if (intentosRestantes > 0)
            {
                if (resultado == true)
                {
                    Form1 ventana = new Form1();
                    this.Hide();
                    ventana.ShowDialog();

                }
                else
                {
                    intentosRestantes--;
                    MessageBox.Show("Datos incorrectos, reintenta nuevamente, Intentos restantes: " + intentosRestantes.ToString());
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
                btnIngresar.Enabled = true;

            else btnIngresar.Enabled = false;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
                btnIngresar.Enabled = true;

            else btnIngresar.Enabled = false;
        }
    }
}
