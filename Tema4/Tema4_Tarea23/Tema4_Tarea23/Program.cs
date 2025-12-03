namespace Tema4_Tarea23
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
                    Console.WriteLine("\n\nIntroduce valores numéricos válidos");
                }

            } while (!esCorrecto);

            return num;
        }

        static int ContarDigitos(int num)
        {
            int contador = 0;

            if (num < 0)
            {
                num = -num;
            }

            while (num > 0)
            {
                num /= 10;
                contador++;
            }

            return contador;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 23: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int num;

            num = LeerNumero("\nIntroduce un número entero: ");

            Console.WriteLine($"\n═> Dígitos contados del número {num}: {ContarDigitos(num)}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
        }
    }
}
