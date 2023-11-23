using DataAPI.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Reportes.ReportePeliculas
{
    public partial class ReportePelículas : Form
    {
        public ReportePelículas()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            dataGridView1.Rows.Clear();
            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@fecha_desde", dtpFechaDesde.Value));
            parametros.Add(new Parametro("@fecha_hasta", dtpFechaHasta.Value));

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("sp_rpt_peliculas", parametros);

            foreach (DataRow r in tabla.Rows)
            {
                string nombre = r["titulo"].ToString();
                string fecha = r["fecha"].ToString();
                int cantidad = int.Parse(r["entradas"].ToString());
                double monto = float.Parse(r["monto"].ToString());

                dataGridView1.Rows.Add(new object[] { nombre, fecha, cantidad.ToString(), "$" + monto.ToString() });

            }
        }
        private void ReportePelículas_Load(object sender, EventArgs e)
        {

            dtpFechaDesde.Value = new DateTime(2023, 1, 1);
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
