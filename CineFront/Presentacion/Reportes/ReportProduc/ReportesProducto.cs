﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Reportes
{
    public partial class ReportesProducto : Form
    {
        public ReportesProducto()
        {
            InitializeComponent();
        }

        private void ReportesProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'producto.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOSTableAdapter.Fill(this.producto.PRODUCTOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
