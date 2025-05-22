using ejercicios.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class FrmArbolBinario: Form
    {
        clases.ArbolBinario ab = new clases.ArbolBinario();
        NodoAB raiz;
        NodoAB seleccionado;
        public FrmArbolBinario()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textNumero.Text, out int num))
            {
                raiz = ab.insertar(null, num);
                treeView1.Nodes.Clear();
                ab.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
            else
            {
                MessageBox.Show("Insertar un número válido!");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            seleccionado = (NodoAB)e.Node.Tag;
        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {
            textNumero.Focus();
        }

        private void btnInsertarRamas_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if(seleccionado !=null)
                {
                    if(rbIzquierda.Checked == true || rbDerecha.Checked == true)
                    {
                        if (rbIzquierda.Checked == true)
                        {
                            seleccionado.izquierdo = ab.insertar(seleccionado.izquierdo, num);
                        }
                        if (rbDerecha.Checked == true)
                        {
                            seleccionado.derecho = ab.insertar(seleccionado.derecho, num);
                        }
                        treeView1.Nodes.Clear();
                        ab.mostrar(raiz, treeView1, null);
                        treeView1.ExpandAll();
                        textNumero.Clear();
                    }MessageBox.Show("Seleccione izquierdo o derecha!");                       
                }
                else MessageBox.Show("Seleccione un número!");
            }
            else
            {
                MessageBox.Show("Insertar un número válido!");
            }
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            int altura = ab.altura(raiz);

            MessageBox.Show("Altura del árbol: " + altura);
        }
    }
}
