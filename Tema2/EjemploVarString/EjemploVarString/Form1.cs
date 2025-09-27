using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploVarString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            string nombre, apellido;
            string nombreCompleto;

            // Aquí recogemos el nombre del textbox correspondiente
            nombre = txtNombre.Text;
            // Aquí recogemos el apellido
            apellido = txtApellido.Text;

            // Aquí montamos la frase final, utilizando la concatenación
            nombreCompleto = "Tu nombre completo es: " + nombre + " " + apellido;

            MessageBox.Show(nombreCompleto);
        }
    }
}
