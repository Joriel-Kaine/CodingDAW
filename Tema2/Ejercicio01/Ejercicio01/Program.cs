using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Salida en consola.
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Identificadores y Tipos");
            Console.WriteLine("=============");

            // Mostrar mensajes en consola de distintos tipos.
            int edad = Utils.PedirEdad();
            Console.WriteLine("Tu edad es de " + edad + " años.");

            string codPostal = Utils.PedirCodPostal();
            Console.WriteLine("Tu código postal es " + codPostal + ".");

            string dni = Utils.PedirDni();
            Console.WriteLine("Tu DNI es " + dni + ".");

            double altura = Utils.PedirAltura();
            Console.WriteLine("Tu altura es de " + altura + " centímetros.");

            char genero = Utils.PedirGenero();
            Console.WriteLine("Tu género es " + genero + ".");

            bool estadoCivil = Utils.EstarCasado();
            Console.WriteLine("¿Estás casado? " + estadoCivil + ".");

            Console.Write("Pulsa una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
