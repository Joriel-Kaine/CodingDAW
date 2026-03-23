using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema8_Tarea02.Base;
using Tema8_Tarea02.Base.Figuras;
using Tema8_Tarea02.Listas;

namespace Tema8_Tarea02.Interfaz
{
    public static class FuncionesInterfazFigura
    {
        // Método que devuelve posiciones x e y, y el color.
        private static void ObtenerPosicionesColor(out int posX, out int posY, out string color)
        {
            posX = FuncionesInterfaz.LeerEntero("Introduce el valor de X:");
            posY = FuncionesInterfaz.LeerEntero("Introduce el valor de Y:");
            color = FuncionesInterfaz.LeerTexto("Introduce el color:");
        }

        // Métodos de creación de círculos y cuadrados.
        public static void CrearCirculo(ListaFiguras listaFiguras)
        {
            int posX, posY, radio;
            string color;

            // Obtención de los datos del círculo.
            ObtenerPosicionesColor(out posX, out posY, out color);
            radio = FuncionesInterfaz.LeerEntero("Introduce el radio del círculo:");

            // Creación del círculo.
            Circulo circulo = new(posX, posY, color, radio);

            // Se añade a la lista de figuras.
            listaFiguras.AddFigura(circulo);
        }

        public static void CrearCuadrado(ListaFiguras listaFiguras)
        {
            int posX, posY, lado;
            string color;

            ObtenerPosicionesColor(out posX, out posY, out color);
            lado = FuncionesInterfaz.LeerEntero("Introduce el lado del cuadrado:");

            Cuadrado cuadrado = new(posX, posY, color, lado);

            listaFiguras.AddFigura(cuadrado);
        }

        public static void MostrarTodasFiguras(ListaFiguras listaFiguras)
        {
            int contador = 1;
            string texto;

            foreach (Figura figura in listaFiguras.DevolverFiguras())
            {
                texto = $"Figura num {contador}\n" +
                        figura.GenerarTextoFigura();

                MessageBox.Show(texto);
                contador++;
            }
        }

        public static void MostrarCirculos(ListaFiguras listaFiguras)
        {
            int contador = 1;
            string texto;

            foreach (Figura figura in listaFiguras.DevolverFiguras())
            {
                if (figura.GetType() == typeof(Circulo))
                {
                    texto = $"Figura num {contador}\n" +
                            figura.GenerarTextoFigura();

                    MessageBox.Show(texto);
                    contador++;
                }
            }
        }

        public static void MostrarCuadrados(ListaFiguras listaFiguras)
        {
            int contador = 1;
            string texto;

            foreach (Figura figura in listaFiguras.DevolverFiguras())
            {
                if (figura.GetType() == typeof(Cuadrado))
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
