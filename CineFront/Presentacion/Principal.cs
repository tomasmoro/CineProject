using CineFront.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront
{
    public partial class Principal : Form
    {
        SeleccionPelicula seleccionPelicula;
        RegistroUsuario registroUsuario;

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
            MessageBox.Show("¿Seguro que quiere salir?", "SALIR", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
        }
    }
}
