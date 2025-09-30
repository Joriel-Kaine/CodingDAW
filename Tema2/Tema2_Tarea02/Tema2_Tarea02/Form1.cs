using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            // Concatenamos los valores introducidos y los mostramos en una caja de mensaje.
            MessageBox.Show("Tu nombre completo es: " + nombre + " " + apellido, "Concatenación");

            // Interpolamos los valores introducidos y los mostramos en una caja de mensaje.
            MessageBox.Show($"Tu nombre completo es: {nombre} {apellido}", "Interpolación");

        }
    }
}
