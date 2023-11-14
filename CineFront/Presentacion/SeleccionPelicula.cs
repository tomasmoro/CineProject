using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CineFront.Presentacion
{
    public partial class SeleccionPelicula : Form
    {
        private Pelicula p = new Pelicula();
        public SeleccionPelicula()
        {
            InitializeComponent();
            cboTipoEntrada.Items.Clear();
            cboTipoEntrada.Visible = false;
            cboTipoEntrada.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTipoEntrada.Items.Add("2D");
            cboTipoEntrada.Items.Add("3D");
        }

        private void MostrarCampos()
        {
            pbrTickets.Value = 20;
            cboTipoEntrada.Visible = true;
            cboTipoEntrada.Enabled = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label7.Text = p.titulo;
        }

        private void pbxPeli1_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            
            
        }

        private void pbxPeli2_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            
        }

        private void pbxPeli3_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            
        }

        private void pbxPeli4_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            
        }

        private void pbxPeli5_Click(object sender, EventArgs e)
        {
            MostrarCampos();
           
        }
    }
}
