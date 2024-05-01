using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos.pry
{
    internal class clsPila
    {
        public clsNodo Primero;
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }
        public void RecorrerGrilla(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerLista(ListBox Lista)
        {
                clsNodo aux = Primero;
                Lista.Items.Clear();
                while (aux != null)
                {
                    Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                    aux = aux.Siguiente;
                }
        }
        public void CompletarCombo(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
    }
}
