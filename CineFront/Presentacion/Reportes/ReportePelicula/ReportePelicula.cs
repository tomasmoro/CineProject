﻿using System;
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

            this.reportViewer1.RefreshReport();
        }
    }
}