using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema3_Tarea24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPesos_Click(object sender, EventArgs e)
        {
            double peso;
            double primerRango = 0, segundoRango = 0,
                tercerRango = 0, cuartoRango = 0;
            double porcentaje = 0;
            double pesoMedio = 0;

            peso = int.Parse(Interaction.InputBox("Introduce el peso del alumno", "Tarea 24", "peso"));

            while (peso >= 0)
            {
                if (peso <= 50)
                {
                    primerRango++;
                }

                if (peso > 50 && peso <= 65)
                {
                    segundoRango++;
                }

                if (peso > 65 && peso <= 80)
                {
                    tercerRango++;
                }

                if (peso > 80)
                {
                    cuartoRango++;
                }

                pesoMedio += peso / 2;

                peso = int.Parse(Interaction.InputBox("Introduce el peso del alumno", "Tarea 24", "peso"));
            }

            MessageBox.Show($"Peso de alumnos con 50 kg o menos: {primerRango}\n" +
                            $"Peso de alumnos entre 51 y 65 kg: {segundoRango}\n" +
                            $"Peso de alumnos entre 66 y 80 kg: {tercerRango}\n" +
                            $"Peso de alumnos con más de 80 kg: {cuartoRango}\n\n\n" +
                            $"El peso medio de todos los alumnos es: {pesoMedio:F2}");
        }
    }
}
