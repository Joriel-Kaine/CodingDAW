namespace Tema4_Tarea24
{
    internal class Program
    {
        // Comprobamos si el número introducido es válido.
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

        // Calculamos el factorial a través de multiplicaciones.
        static double CalcularFactorial(int num)
        {
            int factorial = 1;

            for (int i = num; i > 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        // Calculamos la potencia haciendo tantas multiplicaciones por la base como haya de exponente.
        static double CalcularPotencia(int bbase, int exponente)
        {
            int potencia = 1;

            for (int i = 0; i < exponente; i++)
            {
                potencia *= bbase;
            }

            return potencia;
        }

        // Calculamos la serie con un bucle for en el que "n" será las veces que hay que pasar por él.
        static double CalcularSerie(int m, int n)
        {
            double serie = 0;

            for (int i = 1; i <= n; i++)
            {
                // Vamos sacando cada vez un valor distinto usando "i" cuando llamamos a la función.
                serie += CalcularPotencia(m, i) / CalcularFactorial(i);
            }

            return serie;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 24: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int m, n;

            m = LeerNumero("\nIntroduce el primer número: ");
            n = LeerNumero("\nIntroduce el segundo número: ");

            Console.WriteLine($"\n═> La serie de los numeros {m} y {n} es: {CalcularSerie(m, n):F2}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
        }
    }
}
