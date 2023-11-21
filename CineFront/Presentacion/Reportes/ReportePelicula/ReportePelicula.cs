using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Reportes.ReportePelicula
{
    public partial class ReportePelicula : Form
    {
        public ReportePelicula()
        {
            InitializeComponent();
        }

        private void ReportePelicula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pelicula.PELICULAS' Puede moverla o quitarla según sea necesario.
            this.pELICULASTableAdapter.Fill(this.pelicula.PELICULAS);

            this.reportViewer1.RefreshReport();
        }


    }
}
