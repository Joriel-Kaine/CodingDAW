using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal dinero = decimal.Parse(txtValor.Text);

            /*
             * Redondeando los decimales SIEMPRE abajo con la fórmula Math.Floor.
             * Hacemos casting de la cantidad introducida a entero (int).
             */
            int euros = (int)Math.Floor(dinero);
            /*
             * Multiplicamos la cantidad introducida (con decimales) por cien.
             * Multiplicamos la cantidad de euros sin la parte decimal por cien también.
             * Restamos la cantidad introducida menos la parte sin decimales.
             * Hacemos casting de la operación a entero.
             */
            int centimos = (int)(dinero * 100 - euros * 100);
            
            /*
             * Hacemos las comprobaciones de la cantidad introducida con los diferentes billetes y monedas.
             * Almacenamos el resultado de la división de la cantidad entre el número del billete o moneda.
             * Con esto sabemos cuantos billetes o monedas hay de esa cantidad.
             * Por último actualizamos la cantidad introducida inicialmente quitando los billetes o monedas ya sacados.
             */
            if (euros >= 500)
            {
                int resultado = euros / 500;
                // Sacamos por el label un mensaje diferente dependiendo si es 1 o más billetes.
                if (resultado == 1)
                {
                    lblResultado.Text = $"{resultado} billete de 500 euros.\n";

                }
                else
                {
                    lblResultado.Text = $"{resultado} billetes de 500 euros.\n";
                }
                euros -= resultado * 500;
            }

            if (euros >= 200)
            {
                int resultado = euros / 200;
                if (resultado == 1)
                {
                    // Concatenamos el resultado.
                    lblResultado.Text += $"{resultado} billete de 200 euros.\n";

                }
                else
                {
                    lblResultado.Text += $"{resultado} billetes de 200 euros.\n";
                }
                euros -= resultado * 200;
            }

            if (euros >= 50)
            {
                int resultado = euros / 50;
                if (resultado == 1)
                {
                    lblResultado.Text += $"{resultado} billete de 50 euros.\n";

                }
                else
                {
                    lblResultado.Text += $"{resultado} billetes de 50 euros.\n";
                }
                euros -= resultado * 50;
            }

            if (euros >= 10)
            {
                int resultado = euros / 10;
                if (resultado == 1)
                {
                    lblResultado.Text += $"{resultado} billete de 10 euros.\n";

                }
                else
                {
                    lblResultado.Text += $"{resultado} billetes de 10 euros.\n";
                }
                euros -= resultado * 10;
            }

            if (euros >= 5)
            {
                int resultado = euros / 5;   
                lblResultado.Text += $"{resultado} billete de 5 euros.\n";
                euros -= resultado * 5;
            }

            if (euros >= 2)
            {
                int resultado = euros / 2;
                if (resultado == 1)
                {
                    lblResultado.Text += $"{resultado} moneda de 2 euros.\n";

                }
                else
                {
                    lblResultado.Text += $"{resultado} monedas de 2 euros.\n";
                }
                euros -= resultado * 500;
            }

            if (euros >= 1)
            {
                int resultado = euros;    
                lblResultado.Text += $"{resultado} moneda de 1 euro.\n";
                euros -= resultado;
            }

            // Hacemos lo mismo con los céntimos
            if (centimos >= 50)
            {
                int resultado = centimos / 50;
                // Sacamos por el label un mensaje diferente dependiendo si es 1 o más monedas.
                if (resultado == 1)
                {
                    lblResultado.Text += $"{resultado} moneda de 50 céntimos.\n";

                }
                else
                {
                    lblResultado.Text += $"{resultado} monedas de 50 céntimos.\n";
                }
                centimos -= resultado * 50;
            }

            if (centimos >= 20)
            {
                int resultado = centimos / 20;
                if (resultado == 1)
                {
                    lblResultado.Text += $"{resultado} moneda de 20 céntimos.\n";

                }
                else
                {
                    lblResultado.Text += $"{resultado} monedas de 20 céntimos.\n";
                }
                centimos -= resultado * 20;
            }

            if (centimos >= 10)
            {
                int resultado = centimos / 10;     
                lblResultado.Text += $"{resultado} moneda de 10 céntimos.\n";
                centimos -= resultado * 10;
            }

            if (centimos >= 5)
            {
                int resultado = centimos / 5;           
                lblResultado.Text += $"{resultado} moneda de 5 céntimos.\n";
                centimos -= resultado * 5;
            }

            if (centimos >= 2)
            {
                int resultado = centimos / 2;
                if (resultado == 1)
                {
                    lblResultado.Text += $"{resultado} moneda de 2 céntimos.\n";

                }
                else
                {
                    lblResultado.Text += $"{resultado} monedas de 2 céntimos.\n";
                }
                centimos -= resultado * 2;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /* 
             * Limpiamos el label del resultado y las cajas de texto.
             * Llevamos automáticamente el cursor a la primera caja de texto.
             */
            lblResultado.Text = "";
            txtValor.Clear();
            txtValor.Focus();
            
        }
    }
}
