using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EstructuraDatos.pry
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
            txtCodigo.KeyPress += new KeyPressEventHandler(txtCodigo_KeyPress);
        }
        
        private clsCola cola = new clsCola();

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

                cola.Agregar(nodo);
                cola.RecorrerLista(lstListar);
                cola.RecorrerGrilla(dgvGrilla);
                cola.CompletarCombo(cmbListado);
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            btnEliminar.Enabled = true;
            
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            
            cola.RecorrerGrilla(dgvGrilla);
            cola.RecorrerLista(lstListar);
            cola.CompletarCombo(cmbListado);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cola.Eliminar();
            cola.RecorrerLista(lstListar);
            cola.RecorrerGrilla(dgvGrilla);
            cola.CompletarCombo(cmbListado);

        }
    }
}
