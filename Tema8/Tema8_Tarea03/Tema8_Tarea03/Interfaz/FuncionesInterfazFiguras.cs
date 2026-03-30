using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema8_Tarea03.Modelos;

namespace Tema8_Tarea03.Interfaz
{
    public static class FuncionesInterfazFiguras
    {
        // Métodos de creación de círculos y cuadrados.
        public static void CrearCirculo(List<Figura> listaFiguras, int posX, int posY, string color, int radio)
        {
            // Creación del círculo.
            Circulo circulo = new(posX, posY, color, radio);

            // Se añade a la lista de figuras.
            listaFiguras.Add(circulo);
        }

        public static void CrearCuadrado(List<Figura> listaFiguras, int posX, int posY, string color, int lado)
        {
            // Creación del cuadrado.
            Cuadrado cuadrado = new(posX, posY, color, lado);

            // Se añade a la lista de figuras.
            listaFiguras.Add(cuadrado);
        }

        public static void MostrarTodasFiguras(List<Figura> listaFiguras)
        {
            int contador = 1;
            string texto;

            foreach (Figura figura in listaFiguras)
            {
                texto = $"Figura num {contador}\n" +
                        figura.GenerarTextoFigura();

                MessageBox.Show(texto);
                contador++;
            }
        }

        public static void MostrarCirculos(List<Figura> listaFiguras)
        {
            int contador = 1;
            string texto;

            foreach (Figura figura in listaFiguras)
            {
                if (figura is Circulo circulo)
                {
                    texto = $"Figura num {contador}\n" +
                            figura.GenerarTextoFigura();

                    MessageBox.Show(texto);
                    contador++;
                }
            }
        }

        public static void MostrarCuadrados(List<Figura> listaFiguras)
        {
            int contador = 1;
            string texto;

            foreach (Figura figura in listaFiguras)
            {
                if (figura is Cuadrado cuadrado)
                {
                    texto = $"Figura num {contador}\n" +
                            figura.GenerarTextoFigura();

                    MessageBox.Show(texto);
                    contador++;
                }
            }
        }
    }
}

