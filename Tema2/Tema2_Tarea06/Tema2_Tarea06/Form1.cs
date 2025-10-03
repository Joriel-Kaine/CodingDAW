using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaramos las dos variables.
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);

                // Realizamos la suma.
                int suma = num1 + num2;
                lblSuma.Text = ($"Suma:  {suma}");

                // Realizamos la resta.
                int resta = num1 - num2;
                lblResta.Text = ($"Resta:  {resta}");

                // Realizamos el producto.
                int producto = num1 * num2;
                lblProducto.Text = ($"Producto:  {producto}");

                // Realizamos una división entera.
                int division = num1 / num2;
                lblDivision.Text = ($"División entera:  {division}");

                // Realizamos el resto.
                int resto = num1 % num2;
                lblResto.Text = ($"Resto:  {resto}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Has introducido un valor no numérico en Num1 o Num2.\nPor favor introduce un valor correcto.", "Error de formato");
            }

        }
    }
}
