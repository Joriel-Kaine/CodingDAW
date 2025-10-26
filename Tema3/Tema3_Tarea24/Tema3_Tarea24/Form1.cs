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
            int primerRango = 0, segundoRango = 0,
                tercerRango = 0, cuartoRango = 0;
            int totalAlumnos;
            int porcentajePrimerRango = 0, porcentajeSegundoRango = 0,
                porcentajeTercerRango = 0, porcentajeCuartoRango = 0;
            double pesoTotal = 0, pesoMedio = 0;

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

                pesoTotal += peso;

                peso = int.Parse(Interaction.InputBox("Introduce el peso del alumno", "Tarea 24", "peso"));
            }

            totalAlumnos = primerRango + segundoRango + tercerRango + cuartoRango;
            porcentajePrimerRango = (primerRango * 100) / totalAlumnos;
            porcentajeSegundoRango = (segundoRango * 100) / totalAlumnos;
            porcentajeTercerRango = (tercerRango * 100) / totalAlumnos;
            porcentajeCuartoRango = (cuartoRango * 100) / totalAlumnos;

            pesoMedio = pesoTotal / totalAlumnos;

            MessageBox.Show($"Peso de alumnos con 50 kg o menos: {primerRango}\n" +
                            $"con un porcentaje del total de alumnos de: {porcentajePrimerRango}%\n" +
                            $"Peso de alumnos entre 51 y 65 kg: {segundoRango}\n" +
                            $"con un porcentaje del total de alumnos de: {porcentajeSegundoRango}%\n" +
                            $"Peso de alumnos entre 66 y 80 kg: {tercerRango}\n" +
                            $"con un porcentaje del total de alumnos de: {porcentajeTercerRango}%\n" +
                            $"Peso de alumnos con más de 80 kg: {cuartoRango}\n" +
                            $"con un porcentaje del total de alumnos de: {porcentajeCuartoRango}%\n\n" +
                            $"El peso medio de todos los alumnos es: {pesoMedio:F2} kg", "Calcular Pesos");
        }
    }
}
