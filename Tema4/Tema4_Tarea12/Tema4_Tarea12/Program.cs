namespace Tema4_Tarea12
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

                if (!esCorrecto)
                {
                    Console.WriteLine("\nIntroduce un valor numérico válido.");
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
            Console.WriteLine("\nTema 4 - Tarea 12: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int bbase, exponente;

            try
            {
                bbase = LeerNumero("\nIntroduce la base: ");
                exponente = LeerNumero("\nIntroduce el exponente: ");

                Console.WriteLine($"\n═> La potencia es: {CalcularPotencia(bbase, exponente)}");
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
