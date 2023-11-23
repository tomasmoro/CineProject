using DataApi.DAO.Funciones;
using DataApi.Dominio;
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

namespace CineFront.Presentacion.Reportes.ReporteCliente
{
    public partial class ReporteCliente : Form
    {

        IFuncionDAO funcionDAO;

        public ReporteCliente()
        {
            funcionDAO = new FuncionDAO();
            InitializeComponent();
        }

        private void ReporteCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void CargarDatos()
        {
            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@descripcion", txtName.Text));
            parametros.Add(new Parametro("@dni", txtDNI.Text));

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_RPT_CLIENTES", parametros);
            dataGridView1.DataSource = tabla;

            foreach (DataRow r in tabla.Rows)
            {
                string nombre = r["NOMBRE COMPLETO"].ToString();
                string contacto = r["CONTACTO"].ToString();
                int cantidad = int.Parse(r["CANTIDAD DE ENTRADAS"].ToString());
                double monto = float.Parse(r["MONTO GASTADO"].ToString());

                dataGridView1.Rows.Add(new object[] { nombre, contacto, cantidad.ToString(), "$" + monto.ToString() });

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
