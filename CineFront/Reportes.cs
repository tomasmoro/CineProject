
using CineFront.Presentacion.Reportes.ReporteAsientos;
using CineFront.Presentacion.Reportes.ReporteCliente;
using CineFront.Presentacion.Reportes.ReportePeliculas;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ReporteCliente cliente = new ReporteCliente();
            cliente.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           ReportePelículas pelis = new ReportePelículas();
           pelis.ShowDialog();
            // ReportePelicula reportePelicula = new ReportePelicula();
           // reportePelicula.ShowDialog();
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportePelículas pelis = new ReportePelículas();
            pelis.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReporteAsientos mapacalor = new ReporteAsientos();
            mapacalor.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReporteCliente cliente = new ReporteCliente();
            cliente.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ReporteAsientos mapacalor = new ReporteAsientos();
            mapacalor.ShowDialog();
        }
    }
}
