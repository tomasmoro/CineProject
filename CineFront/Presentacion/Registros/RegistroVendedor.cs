using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Registros
{
    public partial class RegistroVendedor : Form
    {
        public RegistroVendedor()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Today;
            txtContraseña.Text = string.Empty;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiar();
            }
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
