namespace Tema4_Tarea03
{
    internal class Program
    {
        static int MayorDosNumeros (int num1, int num2)
        {
            int mayor = num1;

            if (num1 < num2)
            {
                mayor = num2;
            }

            return mayor;
        }

        const string titulo = "\nTema 4 - Tarea 3: Manuel MR ®\n" +
                              "═════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(titulo);

            bool esCorrecto1, esCorrecto2;
            int num1, num2, mayor;
            string opcion;

            do
            {
                Console.Write("Introduce el primer número: ");
                esCorrecto1 = int.TryParse(Console.ReadLine(), out num1);

                Console.Write("\nIntroduce el segundo número: ");
                esCorrecto2 = int.TryParse(Console.ReadLine(), out num2);

                if (esCorrecto1 && esCorrecto2)
                {
                    mayor = MayorDosNumeros(num1, num2);
                    Console.WriteLine($"\n═> El número mayor de {num1} y {num2} es: {mayor}");
                }
                else
                {
                    Console.WriteLine("\n\nIntroduce valores numéricos válidos.");
                }

                do
                {
                    Console.Write("\n\n¿Quieres volver a introducir números? (S/N): ");
                    opcion = Console.ReadLine();

                    if (opcion == "S" || opcion == "s")
                    {
                        Console.Clear();
                        Console.WriteLine(titulo);
                    }
                    else if (opcion == "N" || opcion == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n\nDebes introducir \"S\" o \"N\".");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(titulo);
                    }

                } while (opcion != "S" && opcion != "s");


            } while (opcion == "S" || opcion == "s");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
