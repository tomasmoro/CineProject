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


namespace CineFront.Presentacion
{
    public partial class SeleccionPelicula : Form
    {
        private Pelicula p = new Pelicula();
        public SeleccionPelicula()
        {
            InitializeComponent();
            txtNombrePeli.Visible = false;
            cboTipoEntrada.Items.Clear();
            cboTipoEntrada.Visible = false;
            cboTipoEntrada.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTipoEntrada.Items.Add("2D");
            cboTipoEntrada.Items.Add("3D");
        }

        private void MostrarCampos()
        {
            pbrTickets.Value = 25;
            cboTipoEntrada.Visible = true;
            cboTipoEntrada.Enabled = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label7.Text = p.titulo;
            label8.Visible = true;
            txtNombrePeli.Visible = true;
            txtNombrePeli.Enabled = false;
            cboFuncion.Visible = true;
            btnAsientos.Visible = true;//una vez cargada la BD, podemos eliminar esto ya que ValidarDatos() chequea si está.
        }

        private bool ValidarDatos()
        {
            bool  validado = true;
            if(label7.Text == "" )
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
            
        }

        private void pbxPeli2_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            txtNombrePeli.Text = "LOS JUEGOS DEL HAMBRE";

        }

        private void pbxPeli3_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            txtNombrePeli.Text = "NAPOLEON";

        }

        private void pbxPeli4_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            txtNombrePeli.Text = "AVATAR";

        }

        private void pbxPeli5_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            txtNombrePeli.Text = "BARBIE";
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SeleccionPelicula_Load(object sender, EventArgs e)
        {

        }

        private void cboFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAsientos.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                pbrTickets.Value = 50;
            }
            
            //Abre el formulario para elegir asientos y posteriormente realizar el pago de las entradas.
                        
        }
    }
}
