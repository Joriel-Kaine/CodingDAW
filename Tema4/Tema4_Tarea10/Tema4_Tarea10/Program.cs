namespace Tema4_Tarea10
{
    internal class Program
    {
        const string titulo = "\nTema 4 - Tarea 10: Manuel MR ®\n" +
                              "══════════════════════════════\n\n";

        static int LeerNumero (string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\nIntroduce un valor numérico valido.");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine(titulo);
                }

            } while (!esCorrecto);

            return num;
        }

        static int NumeroMenor (int num1, int num2)
        {
            int menor = num1;

            if (num1 > num2)
            {
                menor = num2;
            }

            return menor;
        }

        static int MaximoComunDivisor (int num1, int num2)
        {
            int mcd;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(titulo);

            int num1, num2;

            num1 = LeerNumero("\nIntroduce el primer número: ");
            num2 = LeerNumero("\nIntroduce el segundo número: ");

            Console.WriteLine(num1 + num2);

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
