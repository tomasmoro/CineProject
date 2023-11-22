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

namespace CineFront.Presentacion
{
    public partial class InicioSesion : Form { 
    public InicioSesion()
    {
        InitializeComponent();
    }
    private bool ValidarCampos()
    {
        if (textBox2.Text == "")
        {
            MessageBox.Show("Debe insertar un usuasrio valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox1.Text == "")
        {
            MessageBox.Show("Debe insertar una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        return true;
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void txtName_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      
    }

        private static bool ValidarCampoUsuario(TextBox txt)
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


            private async void GetUserData()
    {
        string url = "https://localhost:7229/usuario/" + textBox2.Text + "/" + textBox1.Text;
        using (var client = new HttpClient())
        {
            var result = await client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            bool resultado = JsonConvert.DeserializeObject<bool>(content);

            if (resultado)
            {
                Principal p = new Principal();
                p.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Datos incorrectos, compruebe las credenciales!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoUsuario((TextBox)sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GetUserData();
            }
        }
    }
}
