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
    public partial class FrmListaSimple: Form
    {
        clases.ListaSimple ls = new clases.ListaSimple();
        public FrmListaSimple()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btrInsertar_Click(object sender, EventArgs e)
        {
            listNumeros.Items.Clear();
            ls.insertar(int.Parse(txtNumero.Text));
            ls.mostrar(listNumeros);
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ls.eliminar(int.Parse(txtNumero.Text));
            listNumeros.Items.Clear();
            ls.mostrar(listNumeros);
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btrBuscar_Click(object sender, EventArgs e)
        {
            if(ls.buscar(int.Parse(txtNumero.Text))== true)
            {
                MessageBox.Show("El número si existe en la lista");
            }
            else
                MessageBox.Show("El número no existe en la lista");           
        }

        private void btrOrdenar_Click(object sender, EventArgs e)
        {
            ls.ordenar();
            listNumeros.Items.Clear();
            ls.mostrar(listNumeros);
        }
    }
}
