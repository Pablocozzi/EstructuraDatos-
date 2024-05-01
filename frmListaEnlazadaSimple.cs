using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EstructuraDatos.pry
{
    public partial class frmListaEnlazadaSimple : Form
    {
        public frmListaEnlazadaSimple()
        {
            InitializeComponent();
            txtCodigo.KeyPress += new KeyPressEventHandler(txtCodigo_KeyPress);

        }
        private clsListaSimple listaSimple = new clsListaSimple();

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)//se le asigna a txtCodigo el metodo para que solamente reciba numeros
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void frmCola_Load(object sender, EventArgs e)
        {

            listaSimple.RecorrerGrilla(dgvGrilla);
            listaSimple.RecorrerLista(lstListar);
            listaSimple.CompletarCombo(cmbListado);

        }
        Int32 nodoSeleccionado = 0;
        private void btnAgregar_Click(object sender, EventArgs e)
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

                listaSimple.Agregar(nodo);
                listaSimple.RecorrerLista(lstListar);
                listaSimple.RecorrerGrilla(dgvGrilla);
                listaSimple.CompletarCombo(cmbListado);
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            btnEliminar.Enabled = true;
            

        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            listaSimple.Eliminar(nodoSeleccionado);
            //listaSimple.Eliminar1(nodoSeleccionado);
            listaSimple.RecorrerLista(lstListar);
            listaSimple.RecorrerGrilla(dgvGrilla);
            listaSimple.CompletarCombo(cmbListado);

            MessageBox.Show("Codigo eliminado: " + nodoSeleccionado.ToString());



        }

        
        private void cmbListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            nodoSeleccionado = (Int32)cmbListado.SelectedItem;
             
        }
    }
}
