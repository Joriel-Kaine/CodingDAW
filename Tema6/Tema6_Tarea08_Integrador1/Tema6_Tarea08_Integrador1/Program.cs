namespace Tema6_Tarea08_Integrador1
{
    internal class Program
    {
        const int Tamano = 10;
        const string Texto = "\nDebes cargar los datos primero (opción 1 ó 2).", 
                     Titulo = "\nTema 6 - Integrador 1: Manuel MR ®\n" +
                              "══════════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(Titulo);

            string[] IP = new string[Tamano];
            int[] latencia = new int[Tamano];

            string[] IP2 = { "196.168.0.1", "196.168.12.15", "196.168.82.28",
                             "196.168.55.10", "196.168.12.15", "196.168.47.13",
                             "196.168.8.2", "196.168.90.5", "196.168.12.15", "196.168.6.3"};
            int[] latencia2 = { 56, 8, 44, 12, 25, 10, 68, 20, 15, 2 };

            int opcion, posicion, mayor, menor;
            double media;
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
                        MonitorEquipos.CargarDatosAutomatico(IP, IP2, latencia, latencia2);
                        esLeido = true;
                        Console.WriteLine("\nSe han cargado automáticamente los datos.");
                        break;
                    case 3:
                        if (!esLeido)
                        {
                            Console.WriteLine(Texto);
                        }
                        else
                        {
                            Console.WriteLine(MonitorEquipos.ObtenerListadoRed(IP, latencia));
                        }
                        break;
                    case 4:
                        if (!esLeido)
                        {
                            Console.WriteLine(Texto);
                        }
                        else
                        {
                            Console.Write("\nIntroduce la IP a buscar: ");
                            string direccionIP = Console.ReadLine();

                            posicion = MonitorEquipos.BuscarIP(IP, direccionIP);
                            
                            if (posicion >= 0)
                            {
                                Console.WriteLine($"\nLa latencia de {IP[posicion]} es de: {latencia[posicion]}");
                            }
                            else
                            {
                                Console.WriteLine("\nNo se ha encontrado la dirección IP.");
                            }
                        }
                        break;
                    case 5:
                        if (!esLeido)
                        {
                            Console.WriteLine(Texto);
                        }
                        else
                        {
                            MonitorEquipos.ObtenerEstadisticas(latencia, out mayor, out menor, out media);
                            Console.WriteLine($"\nLa latencia mayor es: {mayor}" +
                                              $"\nLa latencia menor es: {menor}" +
                                              $"\nLa latencia media es: {media}");
                        }
                        break;
                    case 6:
                        MonitorEquipos.OrdenarPorLatencia(IP, latencia);
                        Console.WriteLine("\nSe han ordenado los valores con éxito.");
                        break;
                }

                if (opcion != 7)
                {
                    Console.WriteLine("\nPulsa una tecla para volver al menú...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine(Titulo);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(Titulo);
                }


            } while (opcion != 7);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
