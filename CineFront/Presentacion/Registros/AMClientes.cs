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
    public partial class AMClientes : Form
    {
        private bool esAlta;
        private Cliente cliente;
        public AMClientes(bool esAlta, Cliente c)
        {
            this.esAlta = esAlta;
            this.cliente = c;
      
            InitializeComponent();
        }
        public AMClientes(bool esAlta)
        {
            this.esAlta = esAlta;

            InitializeComponent();
        }

    

        private async void ModificarCliente()
        {

            Cliente cliente = new Cliente(int.Parse(txtdni.Text), txtName.Text, txtLastName.Text, dateTimePicker1.Value, txtMail.Text, txtTelefono.Text);

            string url = "https://localhost:7229/clientes";
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(cliente);
                var result = await client.PutAsync(url, new
                StringContent(json, Encoding.UTF8, "application/json"));

                var content = await result.Content.ReadAsStringAsync();
                if (result.IsSuccessStatusCode)
                {
                    result.Content.ReadAsStringAsync();

                    MessageBox.Show(content, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(content);
                }


            }
        }

        private async void GuardarCliente()
        {
            Cliente cliente = new Cliente(int.Parse(txtdni.Text), txtName.Text, txtLastName.Text, dateTimePicker1.Value, txtMail.Text, txtTelefono.Text);

            string url = "https://localhost:7229/clientes";
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(cliente);
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

        private bool ValidarCampos()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Debe insertar un nombre!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMail.Text == "")
            {
                MessageBox.Show("Debe insertar un mail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Debe insertar un apellido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtdni.Text == "")
            {
                MessageBox.Show("Debe insertar un DNI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe insertar un telefono!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Debe insertar una fecha válida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AMClientes_Load(object sender, EventArgs e)
        {
            if (cliente != null)
            {


                txtName.Text = cliente.nombre;
                txtdni.Text = cliente.id_cliente.ToString();
                txtLastName.Text = cliente.apellido;
                txtMail.Text = cliente.mail;
                txtTelefono.Text = cliente.telefono;
                dateTimePicker1.Value = cliente.fecha_nacimiento;
            }
            if (esAlta)
            {
                label1.Text = "Agregar Cliente";
            }
            else
            {
                label1.Text = "Modificar Cliente";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (esAlta)
                {

                    GuardarCliente();
                }
                else
                {
                    ModificarCliente();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoUsuari((TextBox)sender);
        }
        private static bool ValidarCampoUsuari(TextBox txt)
        {
            try
            {
                int d = Convert.ToInt32(txt.Text);
                return true;
            }
            catch (Exception)
            {
                txt.Text = "0";
                txt.Select(0, txt.Text.Length);

                return false;

            }
        }

        private void ValidarCampoUsuario(TextBox sender)
        {
            throw new NotImplementedException();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

            ValidarCampoUsuari((TextBox)sender);
        }
    }
}
