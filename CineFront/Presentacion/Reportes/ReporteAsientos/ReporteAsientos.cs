using CineFront.Presentacion.PruebaAsientos;
using DataAPI.Datos;
using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CineFront.Presentacion.Reportes.ReporteAsientos
{
    public partial class ReporteAsientos : Form
    {
        private List<ButacaUIReporte> butacas = new List<ButacaUIReporte>();

        public ReporteAsientos()
        {
            InitializeComponent();
        }

        private void ReporteAsientos_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarDataGrid();
            //SP_RPT_butacas
        }

        private void CargarDataGrid()
        {
            dataGridView1.Rows.Clear();
            butacas.Clear();

            List<Parametro> parametros = new List<Parametro>();

            Sala sala = (Sala)comboBox1.SelectedItem;

            parametros.Add(new Parametro("@id_sala", sala.nro_sala));
            
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_RPT_butacas", parametros);
            Image imageDef = Properties.Resources.armchair_lvl_1;
            foreach (DataRow r in tabla.Rows)
            {
                int asiento = int.Parse(r["asiento"].ToString());
                int fila = int.Parse(r["fila"].ToString());
                int cantidad = int.Parse(r["cantidad"].ToString());

                
                butacas.Add(new ButacaUIReporte(asiento, fila, cantidad));
            }

            for (int i = 0; i < 7; i++)
            {
                Image image1 = GetImageFromButaca(i, 0);
                Image image2 = GetImageFromButaca(i, 1);
                Image image3 = GetImageFromButaca(i, 2);
                Image image4 = GetImageFromButaca(i, 3);
                Image image5 = GetImageFromButaca(i, 4);
                Image image6 = GetImageFromButaca(i, 5);
                dataGridView1.Rows.Add(new object[] { image1, image2, image3, image4, image5, image6 });
            }
            dataGridView1.Rows[dataGridView1.NewRowIndex].SetValues(new object[] { imageDef, imageDef, imageDef, imageDef, imageDef, imageDef });
        }

        private Image GetImageFromButaca(int fila, int asiento)
        {
            foreach (ButacaUIReporte b in butacas)
            {
                if (b.fila == fila && b.asiento == asiento)
                {
                    switch (b.cantidad)
                    {
                        case 0:
                            {
                                return Properties.Resources.armchair_lvl_1;
                            }
                        case 1:

                            {
                                return Properties.Resources.armchair_lvl_2;
                            }
                        case 2:

                            {
                                return Properties.Resources.armchair_lvl_3;

                            }
                        case 3:

                            {
                                return Properties.Resources.armchair_lvl_4;

                            }
                        case 4:

                            {
                                return Properties.Resources.armchair_lvl_5;

                            }
                        case 5:

                            {
                                return Properties.Resources.armchair_lvl_6;

                            }
                        default:
                            {
                                return Properties.Resources.armchair_lvl_1;

                            }

                          //  return Properties.Resources.armchair_lvl_1;

                    }


                }
            }

            return AsientoUI.GetDefaultImage();
        }

        private void CargarCombo()
        {
            List<Sala> salas = new List<Sala>();

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("sp_obtener_salas");
            foreach (DataRow r in tabla.Rows)
            {
                int nro_sala = int.Parse(r["nro_sala"].ToString());


                salas.Add(new Sala(nro_sala));
            }

            comboBox1.DataSource = salas;
            comboBox1.ValueMember = "nro_sala";
            comboBox1.DisplayMember = "checkBoxTitle";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDataGrid();
        }
    }

    internal class ButacaUIReporte
    {
        public int cantidad { get; set; }
        public int asiento { get; set; }
        public int fila { get; set; }
        public ButacaUIReporte()
        {

        }
        public ButacaUIReporte(int asiento, int fila, int cantidad)
        {
            this.asiento = asiento;
            this.fila = fila;
            this.cantidad = cantidad;
        }
    }
}
