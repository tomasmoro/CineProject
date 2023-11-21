using CineFront.Presentacion.PruebaAsientos;
using CineFront.Presentacion.Reportes.ReporteCliente;
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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CineFront.Presentacion.Tickets
{
    public partial class Pago : Form
    {

        Factura newFactura;
        public Pago(Factura f)
        {
            newFactura = f;
            InitializeComponent();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            CargarCombos();
            foreach (TicketDetalle t in newFactura.tickets)
            {
                ButacaSala b = t.butaca;
                dataGridView1.Rows.Add(new object[] { b.asiento.ToString() + AsientoUI.getLetter(b.fila), newFactura.funcion.precio_gral.ToString()});
            }
            float total = newFactura.funcion.precio_gral * newFactura.tickets.Count();
            lbltotal.Text = "$"+total.ToString();
            lblentradas.Text = newFactura.tickets.Count().ToString();
        }

        private async void CargarCombos()
        {

            string url = "https://localhost:7229/clientes";
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var content = await result.Content.ReadAsStringAsync();
                List<DataApi.Dominio.Cliente> clientes = JsonConvert.DeserializeObject<List<DataApi.Dominio.Cliente>>(content);

                if (clientes != null)
                {
                    cboClientes.DataSource = clientes;
                }
            }

            url = "https://localhost:7229/vendedores";
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var content = await result.Content.ReadAsStringAsync();
                List<Vendedor> vendedores = JsonConvert.DeserializeObject<List<Vendedor>>(content);

                if (vendedores != null)
                {
                    cboVendedores.DataSource = vendedores;
                }
            }

            url = "https://localhost:7229/formapago";
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var content = await result.Content.ReadAsStringAsync();
                List<FormaPago> formasPago = JsonConvert.DeserializeObject<List<FormaPago>>(content);

                if (formasPago != null)
                {
                    cboFormaPago.DataSource = formasPago;
                }
            }
                        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void cboVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Vendedor v = (Vendedor)cboVendedores.SelectedItem;
            DataApi.Dominio.Cliente c = (DataApi.Dominio.Cliente)cboClientes.SelectedItem;
            FormaPago fp = (FormaPago)cboFormaPago.SelectedItem;

            newFactura.vendedor = v;
            newFactura.cliente = c;
            newFactura.formaPago = fp;

            FuncionDAO dao = new FuncionDAO();

            GuardarFactura();


        }

        private async void GuardarFactura()
        {
            string url = "https://localhost:7229/comprobante";
            using (var client = new HttpClient())
            {

                var json = JsonConvert.SerializeObject(newFactura);
                var result = await client.PostAsync(url, new
                StringContent(json, Encoding.UTF8, "application/json"));

                var content = await result.Content.ReadAsStringAsync();
                if (result.IsSuccessStatusCode)
                {
                    result.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
                else
                {
                    MessageBox.Show(content);
                }
            }
        }
    }
}
