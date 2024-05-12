using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos.pry
{
    internal class clsGrafo
    {
        private String nom;
        public string Nombre { get { return nom; } set { nom = value; } }

        public List<clsGrafo> Grafos;

        public clsGrafo(string Nombre)
        {
            this.nom = Nombre;
            Grafos = new List<clsGrafo>();
        }

        public void Camino(clsGrafo grafo, ListBox lista, string sangria ="")
        {
            
            if (grafo != null)
            {
                
                lista.Items.Add( sangria + "→ " + grafo.nom);
                
                foreach (var i in grafo.Grafos)
                { 
                    Camino(i, lista, sangria+ "\t");  
                }
                
            }
        }

        public void LlenarComboBox(clsGrafo grafo, ComboBox combo, HashSet<string> existentes)
        {
            if (!existentes.Contains(grafo.Nombre))
            {
                combo.Items.Add(grafo.Nombre);
                existentes.Add(grafo.Nombre);
            }    
            foreach (var i in grafo.Grafos)
            {
                LlenarComboBox(i, combo, existentes);
            }
            
        }

        public clsGrafo BuscarNodo(clsGrafo grafo, string nombreNodo)
        {
            if (grafo.Nombre == nombreNodo)
            {
                return grafo;
            }
            else
            {
                foreach (var i in grafo.Grafos)
                {
                    clsGrafo nodoBuscado = BuscarNodo(i, nombreNodo);
                    if (nodoBuscado != null)
                    {
                        return nodoBuscado;
                    }
                }
            }
            return null; 
        }
    }

}
