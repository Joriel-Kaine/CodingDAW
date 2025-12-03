namespace Tema4_Tarea06
{
    internal class Program
    {
        static void Intercambiar (ref int num1, ref int num2)
        {
            int aux;

            aux = num1;
            num1 = num2;
            num2 = aux;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 6: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            bool esCorrecto1, esCorrecto2;
            int num1, num2;

            Console.Write("Introduce el primer número: ");
            esCorrecto1 = int.TryParse(Console.ReadLine(), out num1);

            Console.Write("\nIntroduce el segundo número: ");
            esCorrecto2 = int.TryParse(Console.ReadLine(), out num2);

            if (esCorrecto1 && esCorrecto2)
            {
                Intercambiar(ref num1, ref num2);
                Console.WriteLine($"\n═> El resultado de los números introducidos intercambiados es: {num1} <-> {num2}");
            }
            else
            {
                Console.WriteLine("\n\nIntroduce un valor numérico.");
            }

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
