using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Reportes.ReporteVendedor
{
    public partial class ReporteVendedor : Form
    {
        public ReporteVendedor()
        {
            InitializeComponent();
        }

        private void ReporteVendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENDEDOR.VENDEDORES' Puede moverla o quitarla según sea necesario.
            this.vENDEDORESTableAdapter.Fill(this.vENDEDOR.VENDEDORES);

            this.reportViewer1.RefreshReport();
        }
    }
}
