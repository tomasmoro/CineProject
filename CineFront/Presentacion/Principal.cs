using CineFront.Presentacion;
using CineFront.Presentacion.Registros;
using CineFront.Presentacion.Reportes;
using CineFront.Presentacion.Reportes.ReportePelicula;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront
{
    public partial class Principal : Form
    {
        SeleccionPelicula seleccionPelicula;
        RegistroUsuario registroUsuario;
        RegistroVendedor registroVendedor;
        ReportesProducto reportesProducto;
        ReportePelicula reportePelicula;

        public Principal()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            seleccionPelicula = new SeleccionPelicula();
            seleccionPelicula.Show();
            


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            seleccionPelicula = new SeleccionPelicula();
            seleccionPelicula.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que quiere salir?", "SALIR", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroVendedor = new RegistroVendedor();
            registroVendedor.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
        }

        private void productoMasVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportesProducto = new ReportesProducto();
            reportesProducto.Show();
        }

        private void peliculaMasVistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportePelicula = new ReportePelicula();
            reportePelicula.Show();
        }
    }
}
