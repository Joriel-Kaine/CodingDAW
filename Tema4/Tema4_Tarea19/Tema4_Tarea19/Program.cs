namespace Tema4_Tarea19
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
                    Console.WriteLine("\n\n Introduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static int SepararPesetas (int diezMil, int cincoMil, int dosMil, int mil, int veintiCinco, int uno)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 19: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");



            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
