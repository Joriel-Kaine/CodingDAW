namespace Tema4_Tarea11
{
    internal class Program
    {
        static double LeerDoubleEntre0y10 (string mensaje)
        {
            double num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = double.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto || num < 0 || num > 10)
                {
                    Console.WriteLine("\nIntroduce un valor numérico entre 0 y 10.");
                }

            } while (!esCorrecto || num < 0 || num > 10);

            return num;
        }

        static double CalcularMedia (double nota1, double nota2, double nota3)
        {
            double media;

            media = (nota1 + nota2 + nota3) / 3;

            return media;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 11: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            double nota1, nota2, nota3;

            nota1 = LeerDoubleEntre0y10("\nIntroduce la primera nota: ");
            nota2 = LeerDoubleEntre0y10("\nIntroduce la segunda nota: ");
            nota3 = LeerDoubleEntre0y10("\nIntroduce la tercera nota: ");

            Console.WriteLine($"\n═> La nota media es de: {CalcularMedia(nota1, nota2, nota3):N2}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
