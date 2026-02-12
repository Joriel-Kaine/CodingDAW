using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea02
{
    public static class FuncionesInterfaz
    {
        const string Titulo = "\nTema 7 - Tarea 2: Manuel MR ®\n" +
                              "═════════════════════════════\n\n";

        public static int LeerEntero(string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        public static void LeerFechas(ListaFechas listaFecha)
        {
            int dia, mes, year;
            string opcion = "";

            do
            {
                dia = LeerEntero("\nIntroduce el día: ");
                mes = LeerEntero("\nIntroduce el mes: ");
                year = LeerEntero("\nIntroduce el año: ");

                Fecha fecha = new(dia, mes, year);

                if (fecha.EsFechaValida())
                {
                    listaFecha.AddListaFechas(fecha);
                }
                else
                {
                    Console.WriteLine("\nIntroduce fechas válidas.");
                }

                Console.Write("\n¿Quieres introducir otra fecha? (S/N): ");
                opcion = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Titulo);

            } while (opcion.ToUpper() == "S");
        }

        public static void MostrarFechas(ListaFechas listaFecha)
        {
            Console.WriteLine(listaFecha.MostrarListaFechas());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(Titulo);
        }

        public static int Menu()
        {
            int opcion;

            Console.WriteLine("\nLista de Fechas\n" +
                              "\n1. Leer lista de fechas." +
                              "\n2. Mostrar lista de fechas." +
                              "\n3. Ordenar lista de fechas." +
                              "\n4. Salir del programa.");

            opcion = LeerEntero("\nIntroduce una opción del menú: ");
            Console.WriteLine();

            return opcion;
        }
    }
}
