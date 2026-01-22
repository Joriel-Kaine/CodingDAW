namespace Tema6_Tarea08_Integrador1
{
    internal class Program
    {
        const int Tamano = 10;
        const string texto = "\nDebes introducir valores en el vector.";

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Integrador 1: Manuel MR ®\n" +
                              "══════════════════════════════════\n\n");

            string[] IP = new string[Tamano];
            int[] latencia = new int[Tamano];

            string[] IP2 = { "196.168.0.1", "196.168.12.15", "196.168.82.28",
                             "196.168.55.10", "196.168.18.69", "196.168.47.13",
                             "196.168.8.2", "196.168.90.5", "196.168.1.11", "196.168.6.3"};
            int[] latencia2 = { 56, 8, 44, 12, 25, 10, 68, 20, 15, 2 };

            int opcion;
            bool esLeido = false;

            do
            {
                opcion = MonitorEquipos.Menu();

                switch (opcion)
                {
                    case 1:
                        MonitorEquipos.LeerDatosRed(IP, latencia);
                        esLeido = true;
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                }

            } while (opcion != 7);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
        }
    }
}
