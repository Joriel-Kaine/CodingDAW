namespace Tema4_Tarea13
{
    internal class Program
    {
        static int LeerNumero (string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorto)
                {
                    Console.WriteLine("\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static int CalcularPotencia (int bbase, int exponente)
        {
            int potencia = 1;

            checked
            {
                for (int i = 0; i < exponente; i++)
                {
                    potencia *= bbase;
                }
            }

            return potencia;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 13: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int bbase;

            try
            {
                bbase = LeerNumero("\nIntroduce la base: ");

                Console.WriteLine($"\n═> La potencia con exponente 2 es: {CalcularPotencia(bbase: bbase, exponente: 2)}" +
                                  $"\n═> La potencia con exponente 5 es: {CalcularPotencia(bbase: bbase, exponente: 5)}" +
                                  $"\n═> La potencia con exponente 7 es: {CalcularPotencia(bbase: bbase, exponente: 7)}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nError de OverFlow en la operación.");
            }

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
