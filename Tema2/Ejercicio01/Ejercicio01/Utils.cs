using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class Utils
    {
        public static int PedirEdad()
        {
            // Pedir al usuario que introduzca su edad.
            Console.Write("Por favor, introduce tu edad: ");

            // Leer la entrada del usuario.
            return int.Parse(Console.ReadLine());
        }

        public static string PedirCodPostal()
        {
            // Pedir al usuario que introduzca su código postal.
            Console.Write("Por favor, introduce tu código postal: ");

            // Leer la entrada del usuario.
            return Console.ReadLine();
        }

        public static string PedirDni()
        {
            // Pedir al usuario que introduzca su DNI.
            Console.Write("Por favor, introduce tu DNI: ");

            // Leer la entrada del usuario.
            return Console.ReadLine();
        }

        public static double PedirAltura()
        {
            // Pedir al usuario que introduzca su altura.
            Console.Write("Por favor, introduce tu altura en metros: ");

            // Leer la entrada del usuario.
            return double.Parse(Console.ReadLine());
        }

        public static char PedirGenero()
        {
            // Pedir al usuario que introduzca su género.
            Console.Write("Por favor, introduce tu género (M/F/X): ");

            // Leer la entrada del usuario.
            return char.Parse(Console.ReadLine());
        }

        public static bool EstarCasado()
        {
            // Pedir al usuario que diga si está casado.
            Console.Write("¿Estás casado? (S/N): ");

            // Leer la entrada del usuario.
            string estadoCivil = Console.ReadLine();
            if (estadoCivil == "S" || estadoCivil == "s")
                return true;
            return false;
        }

        public static decimal IntroducirIva()
        {
            // Pedir al usuario que introduzca el IVA.
            Console.Write("Por favor, introduce el IVA (en decimales, no porcentaje): ");

            // Leer la entrada del usuario.
            return decimal.Parse(Console.ReadLine());
        }

        public enum Transporte
        {
            Coche,
            Tren,
            Avión,
            Barco
        }

        public static Transporte PedirTransporte()
        {
            return Transporte.Coche;
        }
    }
}
