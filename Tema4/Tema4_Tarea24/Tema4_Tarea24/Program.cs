namespace Tema4_Tarea24
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
                    Console.WriteLine("\n\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static double CalcularFactorial(int num)
        {
            int factorial = 1;

            for (int i = num; i > 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        static double CalcularPotencia(int bbase, int exponente)
        {
            int potencia = 1;

            for (int i = 0; i < exponente; i++)
            {
                potencia *= bbase;
            }

            return potencia;
        }

        static double CalcularSerie(int m, int n)
        {
            double serie = 0;

            for (int i = 1; i <= n; i++)
            {
                serie += CalcularPotencia(m, i) / CalcularFactorial(i);
            }

            return serie;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 24: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int m, n;

            m = LeerNumero("Introduce el primer número: ");
            n = LeerNumero("Introduce el segundo número: ");

            Console.WriteLine($"La serie de los numeros {m} y {n} es: {CalcularSerie(m, n):F2}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
        }
    }
}
