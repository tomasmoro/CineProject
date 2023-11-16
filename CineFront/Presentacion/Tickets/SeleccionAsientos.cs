using CineFront.Presentacion.PruebaAsientos;
using DataApi.DAO.Funciones;
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

namespace CineFront.Presentacion.Tickets
{
    public partial class SeleccionAsientos : Form
    {
        FuncionesService service = new FuncionesService();
        Funcion newFuncion;
        List<Butaca> butacas = new List<Butaca>();
        public SeleccionAsientos(Funcion funcion)
        {
            InitializeComponent();
            newFuncion = funcion;
        }
        List<Butaca> lButacasSeleccionadas = new List<Butaca>();
        List<TicketDetalle> ltickets = new List<TicketDetalle>();
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Image imageDef = AsientoUI.GetDefaultImage();
            Image imageSel = AsientoUI.GetSelectedImage();
            Image imageOcu = AsientoUI.GetOcuppedImage();

            Butaca b = new Butaca(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex);
            bool estaEnLaLista = false;
            foreach(Butaca but in lButacasSeleccionadas)
            {
                if(but.fila == b.fila && b.asiento == but.asiento)
                {
                    estaEnLaLista = true;
                    break;
                }
            }


            if (!estaEnLaLista)
            {
                
                dataGridView1.CurrentCell.Value = imageSel;
                lButacasSeleccionadas.Add(b);

                string title = b.asiento.ToString()+AsientoUI.getLetter(b.fila);
                listView1.Items.Add(title);

            }
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    
    private void SeleccionAsientos_Load(object sender, EventArgs e)
        {
           
           
            SetEntradas();
           
    }

        private void SetEntradas()
        {
            dataGridView1.Rows.Clear();
            butacas = service.ObtenerButacas(newFuncion);
            Image imageDef = AsientoUI.GetDefaultImage();
            Image imageOcupped = AsientoUI.GetOcuppedImage();
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
            foreach (Butaca b in butacas)
            {
                if (b.fila == fila && b.asiento ==asiento)
                {
                    if (!b.estaDisponible)
                        return AsientoUI.GetOcuppedImage();
                    else break;
                }
            }

            return AsientoUI.GetDefaultImage();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lButacasSeleccionadas.Count != 0)
            {
                foreach(Butaca b in lButacasSeleccionadas)
                {

                    b.id = service.GetIdButaca(b.fila, b.asiento, newFuncion.sala);
                    ltickets.Add(new TicketDetalle(b, newFuncion.precio_gral));
                }
               

                Pago p = new Pago(new Factura(newFuncion, ltickets));
                p.ShowDialog();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lButacasSeleccionadas = new List<Butaca>();
            listView1.Items.Clear();
            SetEntradas();
        }
    }
}
