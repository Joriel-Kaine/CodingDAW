using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema8_Tarea04.Modelos;

namespace Tema8_Tarea04.Interfaz
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

            // Mostramos por consola si se ha creado correctamente.
            MessageBox.Show($"Nuevo círculo creado:\n\n{circulo}");
        }

        public static void CrearCuadrado(List<Figura> listaFiguras, int posX, int posY, string color, int lado)
        {
            // Creación del cuadrado.
            Cuadrado cuadrado = new(posX, posY, color, lado);

            // Se añade a la lista de figuras.
            listaFiguras.Add(cuadrado);

            // Mostramos por consola si se ha creado correctamente.
            MessageBox.Show($"Nuevo cuadrado creado:\n\n{cuadrado}");
        }

        public static void CrearTriangulo(List<Figura> listaFiguras, int posX, int posY, string color, int lado)
        {
            // Creación del cuadrado.
            Triangulo triangulo = new(posX, posY, color, lado);

            // Se añade a la lista de figuras.
            listaFiguras.Add(triangulo);

            // Mostramos por consola si se ha creado correctamente.
            MessageBox.Show($"Nuevo cuadrado creado:\n\n{triangulo}");
        }

        public static void CrearRectangulo(List<Figura> listaFiguras, int posX, int posY, string color, int ancho, int alto)
        {
            // Creación del rectangulo.
            Rectangulo rectangulo = new(posX, posY, color, ancho, alto);

            // Se añade a la lista de figuras.
            listaFiguras.Add(rectangulo);

            // Mostramos por consola si se ha creado correctamente.
            MessageBox.Show($"Nuevo cuadrado creado:\n\n{rectangulo}");
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

        public static void Autorrelleno(List<Figura> listaFiguras)
        {
            CrearCirculo(listaFiguras, 28, 16, "Amarillo", 8);
            CrearCuadrado(listaFiguras, 85, 25, "Magenta", 12);
            CrearCuadrado(listaFiguras, 44, 23, "Azul", 6);
            CrearTriangulo(listaFiguras, 23, 8, "Marrón", 4);
            CrearCirculo(listaFiguras, 62, 39, "Negro", 20);
            CrearCirculo(listaFiguras, 58, 22, "Lila", 16);
            CrearRectangulo(listaFiguras, 48, 20, "Celeste", 24, 14);
            CrearRectangulo(listaFiguras, 82, 47, "Rosa", 46, 31);
            CrearCuadrado(listaFiguras, 70, 60, "Verde", 55);
            CrearTriangulo(listaFiguras, 69, 40, "Lima", 38);
            CrearTriangulo(listaFiguras, 74, 68, "Rojo", 43);
            CrearRectangulo(listaFiguras, 72, 64, "Violeta", 53, 37);

        }

        public static void MostrarListaFiguras(List<Figura> listaFiguras)
        {
            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {

            }
        }
    }
}

