using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Reportes.ReporteCliente
{
    public partial class ReporteCliente : Form
    {
        public ReporteCliente()
        {
            InitializeComponent();
        }

        private void ReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cliente.DtCliente' table. You can move, or remove it, as needed.
            this.dtClienteTableAdapter.Fill(this.cliente.DtCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
