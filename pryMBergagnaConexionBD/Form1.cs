using System;
using System.Windows.Forms;
using pryGestionInventario;

namespace pryMBergagnaConexionBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsConexionBD objConexionBD = new clsConexionBD();

            objConexionBD.ConectarBD();
            objConexionBD.Mostrar(dataGridView1);
        }

    }
}
