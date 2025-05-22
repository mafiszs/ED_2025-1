using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class ArbolBinario
    {
        public NodoAB insertar(NodoAB actual, int num)
        {
            NodoAB nuevo = new NodoAB(num);

            if (actual == null)
            {
                return nuevo;
            }
            else if ((actual.izquierdo != null || actual.derecho == null)&&
                    (actual.izquierdo == null || actual.derecho != null))                   
            {
                MessageBox.Show("Nodo ocupado");
            }
            else if (actual.izquierdo != null)
            {
                actual.izquierdo = nuevo;
            }
            else
            {
                actual.derecho = nuevo;
            }
            return actual;
        }
        public void mostrar(NodoAB actual, TreeView tree, TreeNode padre)
        {
            if(actual == null) return;
            TreeNode nuevo = new TreeNode(actual.numero.ToString());//raiz
            nuevo.Tag = actual;//almacenar dirección de memoria

            if(padre == null)
            {
                tree.Nodes.Add(nuevo);//tallos
            }
            else
            {
                padre.Nodes.Add(nuevo);//hojas
            }
            if (actual.izquierdo != null)
            {
                mostrar(actual.izquierdo, tree, nuevo);
            }
            if (actual.derecho != null)
            {
                mostrar(actual.derecho, tree, nuevo);
            }
        }
        public int altura(NodoAB actual)
        {
            if (actual == null)
            {
                return 0;
            }
            else
            {
                int altIzquierda = altura (actual.izquierdo);
                int altDerecha = altura (actual.derecho);
                return Math.Max(altIzquierda, altDerecha) + 1;
            }
        }
    }

}
