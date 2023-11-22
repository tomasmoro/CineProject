using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Reportes.ReportProduc
{
    public partial class ReporteProducto : Form
    {
        public ReporteProducto()
        {
            InitializeComponent();
        }

        private void ReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRODUCTO.PRODUCTOS' table. You can move, or remove it, as needed.
            this.pRODUCTOSTableAdapter.Fill(this.pRODUCTO.PRODUCTOS);
            // TODO: This line of code loads data into the 'pRODUCTO.PRODUCTOS' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
        }
    }
}
