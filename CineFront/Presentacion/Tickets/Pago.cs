using Aspose.BarCode.Generation;
using CineFront.Presentacion.PruebaAsientos;
using CineFront.Presentacion.Reportes.ReporteCliente;
using DataApi.DAO.Funciones;
using DataApi.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
            DataApi.Dominio.Cliente c = (Cliente)cboClientes.SelectedItem;
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
                    newFactura.nro_factura = int.Parse(content);
                    GenerarQR();

                    if (MessageBox.Show("Se genero con exito!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(content);
                }
            }
        }

        private void EnviarMail(List<string> files)
        {
            Thread.Sleep(2000);
            Cliente cliente = (Cliente)cboClientes.SelectedItem;
            MailMessage mCorreo = new MailMessage();
            mCorreo.From = new MailAddress("tomiezem@gmail.com", "CINEPLEX", System.Text.Encoding.UTF8);

            string dest = "";
            if(checkBox1.Checked)
            {
                dest = cliente.mail;
            } else
            {
                dest = textBox1.Text;

            }
            mCorreo.To.Add(dest);

            mCorreo.Subject = "Cineplex - Entradas - "+newFactura.funcion.pelicula.titulo;
             mCorreo.Body = "<!DOCTYPE html><html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"><link rel=\"stylesheet\" type=\"text/css\" id=\"u0\" href=\"https://es.rakko.tools/tools/129/lib/tinymce/skins/ui/oxide/content.min.css\"><link rel=\"stylesheet\" type=\"text/css\" id=\"u1\" href=\"https://es.rakko.tools/tools/129/lib/tinymce/skins/content/default/content.min.css\"></head><body id=\"tinymce\" class=\"mce-content-body \" data-id=\"content\" contenteditable=\"true\" spellcheck=\"false\"><h2 data-mce-style=\"text-align: center;\" style=\"text-align: center;\"><span style=\"color: rgb(241, 196, 15);\" data-mce-style=\"color: #f1c40f;\"><strong>Cineplex﻿</strong></span><br data-mce-bogus=\"1\"></h2><p style=\"text-align: center;\" data-mce-style=\"text-align: center;\"><span style=\"color: rgb(0, 0, 0);\" data-mce-style=\"color: #000000;\"><strong>Hola&nbsp;<span style=\"color: rgb(241, 196, 15);\" data-mce-style=\"color: #f1c40f;\">"+cliente.nombre+"</span><br data-mce-bogus=\"1\"></strong></span></p><p style=\"text-align: center;\" data-mce-style=\"text-align: center;\"><span style=\"color: rgb(0, 0, 0);\" data-mce-style=\"color: #000000;\"><strong>Gracias por comprar en Cineplex!<br data-mce-bogus=\"1\"></strong></span></p><p style=\"text-align: center;\" data-mce-style=\"text-align: center;\"><span style=\"color: rgb(0, 0, 0);\" data-mce-style=\"color: #000000;\"><strong>Tus entradas fueron adjuntadas en el mail!</strong></span></p><p style=\"text-align: center;\" data-mce-style=\"text-align: center;\"><span style=\"color: rgb(0, 0, 0);\" data-mce-style=\"color: #000000;\"><strong>El día "+newFactura.fecha.ToString()+" debes presentar tu entrada en la puerta de la sala "+newFactura.funcion.sala.nro_sala.ToString()+" !</strong></span></p><p style=\"text-align: center;\" data-mce-style=\"text-align: center;\"><span style=\"color: rgb(0, 0, 0);\" data-mce-style=\"color: #000000;\"><strong>Que disfrutes la película!!</strong></span></p></body></html>";
           
            mCorreo.IsBodyHtml = true;
            mCorreo.Priority = MailPriority.High;
            foreach (string path in files)
            {
                mCorreo.Attachments.Add(new Attachment(path));
            }
            // Adjuntos


            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Port = 25;
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential("tomiezem@gmail.com", "itscaubqhovqrdaf");
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
                smtp.EnableSsl = true;
                smtp.Send(mCorreo);
                MessageBox.Show("Enviado");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
private void GenerarQR()
{
    List<string> files = new List<string>();
            foreach (TicketDetalle t in newFactura.tickets)
            {
                QrSendModel qr = new QrSendModel(newFactura.nro_factura, newFactura.funcion.pelicula.titulo, newFactura.funcion.sala.nro_sala, t.butaca.id_butaca_sala, t.butaca.fila.ToString()+t.butaca.asiento.ToString());
        string str = JsonConvert.SerializeObject(qr);

        // Inicializar una instancia de la clase BarcodeGenerator
                BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, str);
        gen.Parameters.Barcode.XDimension.Pixels = 10;

        // Establecer versión automática
                gen.Parameters.Barcode.QR.QrVersion = QRVersion.Auto;

        //Establecer el tipo de codificación QR de ForceMicroQR
                Random r = new Random();
        int value = r.Next(100000, 999999);
        string fileName = value + "ticket_cineplex.png";
        gen.Parameters.Barcode.QR.QrEncodeType = QREncodeType.ForceQR;
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName;
        files.Add(filePath);
        gen.Save(filePath, BarCodeImageFormat.Png);
                Thread.Sleep(1000);
    }
    EnviarMail(files);
}
private void checkBox1_CheckedChanged(object sender, EventArgs e)
{
    if (checkBox1.Checked)
    {
        cboClientes.Enabled = true;
        textBox1.Enabled = false;
        Cliente c = (Cliente)cboClientes.SelectedItem;
        textBox1.Text = c.mail;
    } else
    {
        cboClientes.Enabled = false;
        textBox1.Enabled = true;
        textBox1.Text = "";
    }
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)cboClientes.SelectedItem;
            textBox1.Text = c.mail;
        }
    }
}
