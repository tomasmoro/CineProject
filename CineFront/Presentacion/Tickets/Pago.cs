using CineFront.Presentacion.PruebaAsientos;
using CineFront.Presentacion.Reportes.ReporteCliente;
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
using static System.Net.Mime.MediaTypeNames;

namespace CineFront.Presentacion.Tickets
{
    public partial class Pago : Form
    {
        FuncionesService service = new FuncionesService();
        Factura newFactura;
        public Pago(Factura f)
        {
            newFactura = f;
            InitializeComponent();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            service = new FuncionesService();

            List<DataApi.Dominio.Cliente> clientes = service.GetClientes();
            List<Vendedor> vendedores = service.GetVendedores();
            List<FormaPago> formasPago = service.getFormasPago();

            cboClientes.DataSource = clientes;
            cboVendedores.DataSource = vendedores;
            cboFormaPago.DataSource = formasPago;



            foreach(TicketDetalle t in newFactura.tickets)
            {
                Butaca b = t.butaca;
                dataGridView1.Rows.Add(new object[] { b.asiento.ToString() + AsientoUI.getLetter(b.fila), newFactura.funcion.precio_gral.ToString()});
            }
            float total = newFactura.funcion.precio_gral * newFactura.tickets.Count();
            lbltotal.Text = "$"+total.ToString();
            lblentradas.Text = newFactura.tickets.Count().ToString();
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

            service.GenerateFactura(newFactura);
            MessageBox.Show("Se genero correctamente");

        }
    }
}
