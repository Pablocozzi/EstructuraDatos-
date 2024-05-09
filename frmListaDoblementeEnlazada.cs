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
    public partial class frmListaDoblementeEnlazada : Form
    {
        public frmListaDoblementeEnlazada()
        {
            InitializeComponent();
            txtCodigo.KeyPress += new KeyPressEventHandler(txtCodigo_KeyPress);

        }
        private clsListaDoble listaDoble = new clsListaDoble();

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)//se le asigna a txtCodigo el metodo para que solamente reciba numeros
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }


        private void frmCola_Load(object sender, EventArgs e)
        {

            listaDoble.RecorrerGrilla(dgvGrilla);
            listaDoble.RecorrerLista(lstListar);
            listaDoble.RecorrerCombo(cmbListado);

        }

        Int32 nodoSeleccionado = 0;

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();

            if (txtCodigo.Text == "" && txtNombre.Text == "" & txtTramite.Text == "")
            {
                MessageBox.Show("Complete los campos");
            }
            else
            {
                nodo.Nombre = txtNombre.Text;
                nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                nodo.Tramite = txtTramite.Text;

                listaDoble.Agregar(nodo);
                listaDoble.RecorrerLista(lstListar);
                listaDoble.RecorrerGrilla(dgvGrilla);
                listaDoble.RecorrerCombo(cmbListado);
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            btnEliminar.Enabled = true;
            btnAscendente.Enabled = true;
            btnDescendente.Enabled = true;
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listaDoble.Eliminar(nodoSeleccionado);
            listaDoble.RecorrerLista(lstListar);
            listaDoble.RecorrerGrilla(dgvGrilla);
            listaDoble.RecorrerCombo(cmbListado);

            MessageBox.Show("Codigo eliminado: " + nodoSeleccionado.ToString());

        }
        private void cmbListado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            nodoSeleccionado = (Int32)cmbListado.SelectedItem;
        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            listaDoble.RecorrerLista(lstListar);
            listaDoble.RecorrerGrilla(dgvGrilla);
            listaDoble.RecorrerCombo(cmbListado);
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            listaDoble.RecorrerListaDes(lstListar);
            listaDoble.RecorrerGrillaDes(dgvGrilla);
            listaDoble.RecorrerComboDes(cmbListado);
        }
    }
}
