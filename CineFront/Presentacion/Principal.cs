using CineFront.Presentacion;
using CineFront.Presentacion.Registros;
using CineFront.Presentacion.Reportes;
using CineFront.Presentacion.Reportes.ReporteVendedor;
using CineFront.Presentacion.Reportes.ReporteCliente;
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
using CineFront.Presentacion.Reportes.ReportProduc;

namespace CineFront
{
    public partial class Principal : Form
    {
        SeleccionPelicula seleccionPelicula;
        RegistroCliente registroUsuario;
        //RegistroVendedor registroVendedor;
        ReporteProducto reportesProducto;
        ReportePelicula reportePelicula;
        ReporteCliente reporteCliente;
        ReporteVendedor reporteVendedor; 

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
            if(MessageBox.Show("¿Seguro que quiere salir?", "SALIR", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            registroUsuario = new RegistroCliente();
            registroUsuario.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registroUsuario = new RegistroCliente();
            registroUsuario.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroUsuario = new RegistroCliente();
            registroUsuario.Show();
        }

        private void productoMasVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportesProducto = new ReporteProducto();
            reportesProducto.Show();
        }

        private void peliculaMasVistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportePelicula = new ReportePelicula();
            reportePelicula.ShowDialog();
        }

        private void clientesMasCompraronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteCliente = new ReporteCliente();
            reporteCliente.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }

        private void listaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteVendedor = new ReporteVendedor();
            reporteVendedor.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
