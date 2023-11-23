using CineFront.Presentacion;
using CineFront.Presentacion.Registros;
using System;
using System.Windows.Forms;

namespace CineFront
{
    public partial class Principal : Form
    {
        SeleccionPelicula seleccionPelicula;
        RegistroCliente registroUsuario;
        //RegistroVendedor registroVendedor;
        public Principal()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            seleccionPelicula = new SeleccionPelicula();
            seleccionPelicula.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            seleccionPelicula = new SeleccionPelicula();
            seleccionPelicula.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quiere salir?", "SALIR", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            registroUsuario = new RegistroCliente();
            registroUsuario.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registroUsuario = new RegistroCliente();
            registroUsuario.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }



        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
