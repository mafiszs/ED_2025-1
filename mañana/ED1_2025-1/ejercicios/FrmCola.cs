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
    public partial class FrmCola: Form
    {
        clases.Cola c = new clases.Cola();
        public FrmCola()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("no se permite nombres nulos");
            }
            else
            {
                listDatos.Items.Clear();
                c.Enqueue(textNombre.Text.Trim());
                c.mostrar(listDatos);
                textNombre.Clear();
                textNombre.Focus();
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            string nom = c.dequeue();
            if (nom != null)
            {
                MessageBox.Show($"{nom} atentido!");
                listDatos.Items.Clear();
                c.mostrar(listDatos);
                textNombre.Focus();
            }
            else MessageBox.Show("Cola vacía!");
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string nom = c.Peek();
            if (nom != null)
            {
                MessageBox.Show($"Primero en la cola: {nom} ");
                textNombre.Focus();
            }
            else
                MessageBox.Show("Cola vacía!");
        }

        private void btnCantidaddeElementos_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"cantidad: {c.Count()}");
            textNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c.Clear();
            textNombre.Focus();
            listDatos.Items.Clear();
            MessageBox.Show("Se limpia los datos");
        }
    }
}
