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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
            txtCodigo.KeyPress += new KeyPressEventHandler(txtCodigo_KeyPress);
        }
        private clsPila pila = new clsPila();
        
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)//se le asigna a txtCodigo el metodo para que solamente reciba numeros
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

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

                pila.Agregar(nodo);
                pila.RecorrerLista(lstListar);
                pila.RecorrerGrilla(dgvGrilla);
                pila.CompletarCombo(cmbListado);
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            btnEliminar.Enabled = true;
        }

        private void frmPila_Load(object sender, EventArgs e)
        {
            pila.RecorrerGrilla(dgvGrilla);
            pila.RecorrerLista(lstListar);
            pila.CompletarCombo(cmbListado);
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            pila.Eliminar();
            pila.RecorrerLista(lstListar);
            pila.RecorrerGrilla(dgvGrilla);
            pila.CompletarCombo(cmbListado);
        }
    }
}
