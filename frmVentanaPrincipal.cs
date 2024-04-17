using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos.pry
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesarrollador ventana = new frmDesarrollador();
            ventana.Show();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola ventana = new frmCola();
            ventana.Show();
        }

        private void pillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila ventana = new frmPila();
            ventana.Show();
        }

        private void listaEnlazadaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazadaSimple ventana = new frmListaEnlazadaSimple();
            ventana.Show();
        }

        private void listaDoblementeEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoblementeEnlazada ventana = new frmListaDoblementeEnlazada();
            ventana.Show();
        }

        private void arbolBinarioDeBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario ventana = new frmArbolBinario();
            ventana.Show();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo ventana = new frmGrafo();
            ventana.Show(); 
        }
    }
}
