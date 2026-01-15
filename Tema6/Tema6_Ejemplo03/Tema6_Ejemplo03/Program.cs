namespace Tema6_Ejemplo03
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
                // Si lo que leemos no es un entero devuelve false.
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);
            // Continuamos pidiendo el número mientras no sea correcto.

            return num;
        }

        static void LeerVector(int[] vector)
        {
            // Leemos todos los elementos del vector.
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = LeerNumero($"Introduce el valor de la posición {i}: ");
            }
        }

        static string MostrarVector(int[] vector)
        {
            string texto;

            texto = "Elementos del vector: \n";
            for (int i = 0; i < vector.Length; i++)
            {
                texto += $"{vector[i]}, ";
            }

            return texto;
        }

        const int Tamano = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Ejemplo 3: Manuel MR ®\n" +
                              "═══════════════════════════════\n\n");

            int[] numeros = new int[Tamano];

            LeerVector(numeros);

            Console.WriteLine($"\n{MostrarVector(numeros)}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}

