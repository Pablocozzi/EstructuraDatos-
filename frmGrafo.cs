using System;
using System.Collections;
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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }


        private void btnGrafo_Click(object sender, EventArgs e)
        {
            clsGrafo grafo = GrafoPrincipal();
            lstCamino.Items.Clear();
            grafo.Camino(grafo, lstCamino);

            if (lstCamino.Items.Count == 0)
            {
                MessageBox.Show("La lista está vacía.");
            }

        }

        private clsGrafo GrafoPrincipal()
        {
            clsGrafo A = new clsGrafo("Córdoba, Argentina");
            clsGrafo B = new clsGrafo("Santiago de Chile, Chile");
            clsGrafo C = new clsGrafo("Rio de Janeiro, Brasil");
            clsGrafo D = new clsGrafo("Lima, Perú");
            clsGrafo E = new clsGrafo("Quito, Ecuador");
            clsGrafo F = new clsGrafo("Bogota, Colombia");

            A.Grafos.Add(B);
            B.Grafos.Add(C);
            B.Grafos.Add(D);
            C.Grafos.Add(E);
            C.Grafos.Add(F);
            D.Grafos.Add(E);
            E.Grafos.Add(F);

            return (A);
        }

        private void cmbCamino_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsGrafo grafo = GrafoPrincipal();
            lstCamino.Items.Clear();
            if (cmbCamino.SelectedIndex != -1) 
            {              
                string nombreNodoSeleccionado = cmbCamino.SelectedItem.ToString();
                clsGrafo nodoSeleccionado = grafo.BuscarNodo(grafo, nombreNodoSeleccionado);

                grafo.Camino(nodoSeleccionado, lstCamino);
            }
            
        }

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            clsGrafo grafo = GrafoPrincipal();
            HashSet<string> nodosAgregados = new HashSet<string>();

            grafo.LlenarComboBox(grafo, cmbCamino, nodosAgregados);
        }
    }
}
