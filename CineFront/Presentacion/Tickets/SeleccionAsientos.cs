using CineFront.Presentacion.PruebaAsientos;
using DataApi.DAO.Funciones;
using DataApi.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Tickets
{
    public partial class SeleccionAsientos : Form
    {

        Funcion newFuncion;
        List<Butaca> butacas = new List<Butaca>();
        public SeleccionAsientos(Funcion funcion)
        {
            InitializeComponent();
            newFuncion = funcion;
        }
        private List<Butaca> lButacasSeleccionadas = new List<Butaca>();
        private List<TicketDetalle> ltickets = new List<TicketDetalle>();
        private List<Butaca> lAsientosOcupados = new List<Butaca>();

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Image imageDef = AsientoUI.GetDefaultImage();
            Image imageSel = AsientoUI.GetSelectedImage();
            Image imageOcu = AsientoUI.GetOcuppedImage();

            Butaca b = new Butaca(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex);
            bool estaEnLaLista = false;
            bool estaOcupada = false;
            foreach (Butaca but in lButacasSeleccionadas)
            {
                if (but.fila == b.fila && b.asiento == but.asiento)
                {
                    estaEnLaLista = true;
                    break;
                }

            }


            foreach (Butaca but in lAsientosOcupados)
            {
                if (but.fila == b.fila && b.asiento == but.asiento)
                {
                    if (!but.esta_disponible)
                        estaOcupada = true;

                    break;

                }
            }


            if (!estaEnLaLista && !estaOcupada)
            {

                dataGridView1.CurrentCell.Value = imageSel;
                lButacasSeleccionadas.Add(b);

                string title = b.asiento.ToString() + AsientoUI.getLetter(b.fila);
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

        private async void SetEntradas()
        {
            dataGridView1.Rows.Clear();

            string url = "https://localhost:7229/butacas/" + newFuncion.id_funcion + "/" + newFuncion.sala.nro_sala;
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var content = await result.Content.ReadAsStringAsync();
                List<Butaca> b = JsonConvert.DeserializeObject<List<Butaca>>(content);

                if (b != null)
                {
                    butacas = b;
                }
            }
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
                if (b.fila == fila && b.asiento == asiento)
                {
                    if (!b.esta_disponible)
                    {

                        lAsientosOcupados.Add(b);
                        return AsientoUI.GetOcuppedImage();

                    }

                    else break;
                }
            }

            return AsientoUI.GetDefaultImage();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (lButacasSeleccionadas.Count != 0)
            {
                foreach (Butaca b in lButacasSeleccionadas)
                {

                    string url = "https://localhost:7229/asientos/" + b.asiento + "/" + b.fila + "/" + newFuncion.sala.nro_sala;
                    using (var client = new HttpClient())
                    {
                        var result = await client.GetAsync(url);
                        var content = await result.Content.ReadAsStringAsync();
                        Int32 id = JsonConvert.DeserializeObject<Int32>(content);

                        if (id != null)
                        {
                            ButacaSala bs = new ButacaSala(id, b.asiento, b.fila, newFuncion.sala);
                            ltickets.Add(new TicketDetalle(bs, newFuncion.precio_gral));
                        }
                    }
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
            lButacasSeleccionadas.Clear();
            listView1.Items.Clear();
            lAsientosOcupados.Clear();
            SetEntradas();
        }
    }
}
