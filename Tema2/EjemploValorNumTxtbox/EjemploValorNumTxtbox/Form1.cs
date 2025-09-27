using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploValorNumTxtbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            // Declaración de variable.
            int numero;

            // Asignación de valor a la variable.
            numero = int.Parse(txtNumero.Text);

            // Mostrar valor de la variable en un MessageBox.
            MessageBox.Show(numero.ToString());

        }
    }
}
