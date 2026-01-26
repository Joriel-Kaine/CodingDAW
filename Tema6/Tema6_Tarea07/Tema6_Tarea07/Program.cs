namespace Tema6_Tarea07
{
    internal class Program
    {
        const int Tamano = 24;
        const string texto = "\nDebes introducir valores en el vector.";

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 6 - Tarea 7: Manuel MR ®\n" +
                              "═════════════════════════════\n\n");

            int[] numeros = new int[Tamano];
            int opcion, menor, mayor;
            double media;
            bool esLeido = false;

            do
            {
                opcion = RegistroTemperaturas.Menu();

                switch (opcion)
                {
                    case 1:
                        RegistroTemperaturas.LeerTemperatura(numeros);
                        esLeido = true;
                        break;
                    case 2:
                        if (!esLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            Console.WriteLine(RegistroTemperaturas.GenerarTextoTemperatura(numeros));
                        }
                        break;
                    case 3:
                        if (!esLeido)
                        {
                            Console.WriteLine(texto);
                        }
                        else
                        {
                            Console.WriteLine($"\nLa temperatura menor del día es: " +
                                              $"{RegistroTemperaturas.ObtenerMenorTemperatura(numeros)}" +
                                              $"\nLa temperatura mayor del día es: " +
                                              $"{RegistroTemperaturas.ObtenerMayorTemperatura(numeros)}" +
                                              $"\nLa temperatura media del día es: " +
                                              $"{RegistroTemperaturas.ObtenerTemperaturaMedia(numeros)}");
                            /*
                            RegistroTemperaturas.ObtenerDatos(numeros, out menor, out mayor, out media);
                            Console.WriteLine($"\nLa temperatura menor del día es: {menor}" +
                                              $"\nLa temperatura mayor del día es: {mayor}" +
                                              $"\nLa temperatura media del día es: {media}");
                            */
                        }
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
