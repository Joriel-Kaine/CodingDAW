namespace Tema5_Ejemplo01
{
    internal class Program
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
                    Console.WriteLine("\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static int Menu()
        {
            int opcion;

            do
            {
                Console.WriteLine("\nMenú.");
                Console.WriteLine("1. Introducir datos del empleado.");
                Console.WriteLine("2. Mostrar datos del empleado.");
                Console.WriteLine("3. Cumpleaños del empleado.");
                Console.WriteLine("4. Añadir venta.");
                Console.WriteLine("5. Salir del programa.");

                opcion = LeerNumero("\nIntroduzca la opción: ");

            } while (opcion < 1 || opcion > 5);

            return opcion;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 5 - Ejemplo 1: Manuel MR ®\n" +
                              "═══════════════════════════════\n\n");

            Empleado emp = new();
            int opcion;

            do
            {
                opcion = Menu();

                switch (opcion)
                {
                    case 1:
                        LeerDatosEmpleado(emp);
                        break;
                    case 2:
                        Console.WriteLine(emp.MostrarDatos());
                        break;
                    case 3:
                        emp.Birthday();
                        break;
                    case 4:
                        AddVenta(emp);
                        break;
                }

            } while (opcion != 5);

            Console.WriteLine("\nFin del programa.");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }

        static void LeerDatosEmpleado(Empleado emp)
        {
            try
            {
                Console.Write("Introduzca el nombre del empleado: ");
                emp.Nombre = Console.ReadLine();
                emp.Edad = LeerNumero("Introduzca la edad: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nHa saltado la siguiente excepción: {ex.Message}");
            }
        }

        static void AddVenta(Empleado emp)
        {
            double venta;

            Console.Write("Introduce la venta: ");
            if (double.TryParse(Console.ReadLine(), out venta))
            {
                emp.AddVenta(venta);
            }
            else
            {
                Console.WriteLine("No ha introducido ouna venta correcta");
            }
        }
    }
}
