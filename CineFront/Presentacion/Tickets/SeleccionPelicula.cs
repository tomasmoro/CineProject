using CineFront.Presentacion.Tickets;
using DataApi.DAO.Funciones;
using DataApi.Dominio;
using DataAPI.Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace CineFront.Presentacion
{
    public partial class SeleccionPelicula : Form
    {
        private Funcion newFuncion = new Funcion();
        private Pelicula peliculaSeleccionada;
        private TipoSala tipoSalaSeleccionada;

        public SeleccionPelicula()
        {
            InitializeComponent();
        }

        private void MostrarCampos()
        {
            pbrTickets.Value = 25;
            cboTipoEntrada.Visible = true;
            cboTipoEntrada.Enabled = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            txtNombrePeli.Visible = true;
            txtNombrePeli.Enabled = false;
            cboFuncion.Visible = true;
            btnAsientos.Visible = true;//una vez cargada la BD, podemos eliminar esto ya que ValidarDatos() chequea si está.
        }

        private bool ValidarDatos()
        {
            bool  validado = true;
            if(txtNombrePeli.Text == "" )
            {
                MessageBox.Show("Debe seleccionar una pelicula.");
                validado = false;
            }
            else if (cboTipoEntrada.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrada.");
                validado = false;
            }
            else if(cboFuncion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una función.");
                validado = false;
            }
            return validado;
        }

        private void pbxPeli1_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            txtNombrePeli.Text = "THE MARVELS";

            peliculaSeleccionada = new Pelicula(5, "THE MARVELS");
            CargarComboTipoSala();

        }

        private void pbxPeli2_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            txtNombrePeli.Text = "LOS JUEGOS DEL HAMBRE";
            peliculaSeleccionada = new Pelicula(7, "LOS JUEGOS DEL HAMBRE");
            CargarComboTipoSala();

        }

        private void pbxPeli3_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            txtNombrePeli.Text = "NAPOLEON";
            peliculaSeleccionada = new Pelicula(6, "NAPOLEON");
            CargarComboTipoSala();

        }

        private void pbxPeli4_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            txtNombrePeli.Text = "AVATAR 2";
            peliculaSeleccionada = new Pelicula(8, "AVATAR");
            CargarComboTipoSala();

        }

        private void pbxPeli5_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            txtNombrePeli.Text = "BARBIE";
            peliculaSeleccionada = new Pelicula(9, "BARBIE");
            CargarComboTipoSala();
        }

        private async void CargarComboTipoSala()
        {
            cboTipoEntrada.DataSource = null;

            string url = "https://localhost:7229/tipo_sala/" + peliculaSeleccionada.id_pelicula;
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var content = await result.Content.ReadAsStringAsync();
                List<TipoSala> tipos = JsonConvert.DeserializeObject<List<TipoSala>>(content);

                if (tipos != null)
                {
                    cboTipoEntrada.DataSource = tipos;

                    cboTipoEntrada.DisplayMember = "Tipo_sala";

                    cboTipoEntrada.ValueMember = "Id_tipo_sala";

                }
            }

        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<Pelicula> peliculas = new List<Pelicula>();

        private void SeleccionPelicula_Load(object sender, EventArgs e)
        {
           /* Stream StreamImagen;
            string elError = "";
            StreamImagen = getUrl("https://static.wikia.nocookie.net/esharrypotter/images/3/35/Harry_Potter_y_el_Prisionero_de_Azkaban_%28DVD%29.png/revision/latest?cb=20110208175552");
            if (elError == "")
            {
                pbxPeli1.Image = System.Drawing.Image.FromStream(StreamImagen);
            }
            else
            {
                //MsgBox(elError);
            }*/
            txtNombrePeli.Visible = false;
            cboTipoEntrada.Items.Clear();
            cboTipoEntrada.Visible = false;
            cboTipoEntrada.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                pbrTickets.Value = 50;

                SeleccionAsientos s = new SeleccionAsientos(newFuncion);
                s.ShowDialog();
            }
            
            //Abre el formulario para elegir asientos y posteriormente realizar el pago de las entradas.
                        
        }

        private void cboTipoEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if(cboTipoEntrada.SelectedIndex != -1)
            {
                tipoSalaSeleccionada = (TipoSala)cboTipoEntrada.SelectedItem;
                CargarComboFunciones();
            }
        }

        private async void CargarComboFunciones()
        {
            cboFuncion.Enabled = true;
            cboFuncion.DropDownStyle = ComboBoxStyle.DropDownList;


            string url = "https://localhost:7229/peliculas/" + peliculaSeleccionada.id_pelicula + "/" + tipoSalaSeleccionada.Id_tipo_sala;
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var content = await result.Content.ReadAsStringAsync();
                List<Funcion> funciones = JsonConvert.DeserializeObject<List<Funcion>>(content);

                if (funciones != null) { 
                foreach (Funcion f in funciones)
                {
                    f.pelicula = peliculaSeleccionada;
                }

                cboFuncion.DataSource = funciones;

                cboFuncion.DisplayMember = "cboText";

                cboFuncion.ValueMember = "id_funcion";
            }
            }
        }

        private void cboFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboFuncion.SelectedIndex != -1)
            {
                newFuncion = (Funcion)cboFuncion.SelectedItem;
            }
        }

        private Stream getUrl(string URL)
        {

            string strResp = "";
            HttpWebRequest request = ((HttpWebRequest)WebRequest.Create(URL));

            HttpWebResponse response = ((HttpWebResponse)request.GetResponse());

            try
            {

                return response.GetResponseStream();

            }
            catch
            {
                return response.GetResponseStream();
                //elError = ex.ToString();
            }

        }
    
    }
}
