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

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 3: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            bool esCorrecto1, esCorrecto2;
            int num1, num2, mayor;

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

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
