using CineFront.Presentacion.Tickets;
using DataApi.DAO.Funciones;
using DataApi.Dominio;
using DataAPI.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        FuncionesService fService;

        public SeleccionPelicula()
        {
            InitializeComponent();

            fService = new FuncionesService();
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

        private void CargarComboTipoSala()
        {
            cboTipoEntrada.DataSource = null;
            List<TipoSala> tipos = fService.ObtenerTiposPorFuncion(peliculaSeleccionada);
            cboTipoEntrada.DataSource = tipos;

            cboTipoEntrada.DisplayMember = "Tipo_sala";

            cboTipoEntrada.ValueMember = "Id_tipo_sala";

        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<Pelicula> peliculas = new List<Pelicula>();

        private void SeleccionPelicula_Load(object sender, EventArgs e)
        {
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

        private void CargarComboFunciones()
        {
            cboFuncion.Enabled = true;
            cboFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            List<Funcion> funciones = fService.GetFuncionesByPelicula(peliculaSeleccionada, tipoSalaSeleccionada);

            cboFuncion.DataSource = funciones;

            cboFuncion.DisplayMember = "cboText";

            cboFuncion.ValueMember = "id";
        }

        private void cboFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboFuncion.SelectedIndex != -1)
            {
                newFuncion = (Funcion)cboFuncion.SelectedItem;
            }
        }
    }
}
