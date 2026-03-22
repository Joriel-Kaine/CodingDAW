using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        }
    }
}
