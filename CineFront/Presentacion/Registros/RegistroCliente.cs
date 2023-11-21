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

namespace CineFront.Presentacion.Registros
{
    public partial class RegistroCliente : Form
    {

        List<Cliente> clientes = new List<Cliente>();

        public RegistroCliente()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtCodigo.Text = string.Empty;
        }

        private async void CargarClientes()
        {
            dataGridView1.Rows.Clear();
            List<Cliente> lista = new List<Cliente>();
            string url = "https://localhost:7229/clientes";
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var content = await result.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Cliente>>(content);

                if (lista != null)
                {
                    clientes = lista;
                    foreach (Cliente c in lista)
                    {
                        dataGridView1.Rows.Add(new object[] { c.id_cliente, c.nombre + " " + c.apellido, c.fecha_nacimiento.ToString(), c.mail, "Quitar", "Modificar" });
                    }
                }
            }
        }


        private async void CargarClientesFiltrados()
        {
            List<Cliente> lista = new List<Cliente>();
            string url = "https://localhost:7229/clientes/" + txtCodigo.Text;
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var content = await result.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Cliente>>(content);
                dataGridView1.Rows.Clear();
                if (lista != null)
                {
                    clientes = lista;

                    foreach (Cliente c in lista)
                    {
                        dataGridView1.Rows.Add(new object[] { c.id_cliente, c.nombre + " " + c.apellido, c.fecha_nacimiento.ToString(), c.mail, "Quitar", "Modificar" });
                    }
                }
            }
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

            CargarClientes();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarClientesFiltrados();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                Cliente c = new Cliente(id);

                BorrarCliente(c);
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                Cliente c = new Cliente();
                foreach(Cliente c1 in clientes)
                {
                    int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    if(id == c1.id_cliente)
                    {
                        c = c1;
                        break;
                    }
                }
                AMClientes clienteDialog = new AMClientes(false, c);
                clienteDialog.ShowDialog();
            }
        }

        private async void BorrarCliente(Cliente c) 
        {
            
            string url = "https://localhost:7229/del_clientes/";
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(c);
                var result = await client.PostAsync(url, new
                StringContent(json, Encoding.UTF8, "application/json"));
                CargarClientes();
               
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            AMClientes c = new AMClientes(true);
            c.ShowDialog();
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
