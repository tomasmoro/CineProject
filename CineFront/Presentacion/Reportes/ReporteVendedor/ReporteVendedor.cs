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
            // TODO: This line of code loads data into the 'vENDEDOR.VENDEDORRRRR' table. You can move, or remove it, as needed.
            this.vENDEDORRRRRTableAdapter.Fill(this.vENDEDOR.VENDEDORRRRR);

            this.reportViewer1.RefreshReport();
        }
    }
}
