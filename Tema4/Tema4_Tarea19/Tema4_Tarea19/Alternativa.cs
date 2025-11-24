using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Tarea19
{
    internal class Alternativa
    {
        static int LeerNumero(string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\n\n Introduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        // Función donde metemos en el texto el número de billetes correspondiente.
        // cantidadDinero será el dinero que nos queda por analizar (es ref porque es de entrada salida)
        // texto es ref porque entra con un texto y sale con más texto...
        // tipoBillete es el billete que nos toca analizar. 10000, 5000, ...
        static void CalcularBilletes(ref int cantidadDinero, ref string texto, int tipoBillete)
        {
            int numBilletes;

            // Si la cantidad es mayor o igual que el billete correspondiente 
            // tendremos que ver cuantos billetes hay y meterlo en el texto
            // Si es menor no hay billetes
            if (cantidadDinero >= tipoBillete)
            {
                // Obtenemos el número de billetes
                numBilletes = cantidadDinero / tipoBillete;

                // Lo reflejamos en el texto
                texto = texto + numBilletes + " billetes de " + tipoBillete + "\n";
                // También podría ser una cadena interpolada:
                //texto = $"{texto}{numBilletes} billetes de {tipoBillete}\n";
                // ó
                //texto += $"{numBilletes} billetes de {tipoBillete}\n";

                // Nos quedamos con el resto de dinero que nos queda
                cantidadDinero = cantidadDinero % tipoBillete;
            }
        }

        static string ObtenerTextoConBilletes(int cantidadDinero)
        {
            string texto = "";

            CalcularBilletes(ref cantidadDinero, ref texto, 10000);
            CalcularBilletes(ref cantidadDinero, ref texto, 5000);
            CalcularBilletes(ref cantidadDinero, ref texto, 2000);
            CalcularBilletes(ref cantidadDinero, ref texto, 100);
            // Realmente deberíamos hacer algo para que con 25 y 5 
            // salga el texto "moneda" en vez de "billete".
            CalcularBilletes(ref cantidadDinero, ref texto, 25);
            CalcularBilletes(ref cantidadDinero, ref texto, 1);

            return texto;
        }
    }
}
