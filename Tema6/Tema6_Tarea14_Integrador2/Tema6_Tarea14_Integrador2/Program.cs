namespace Tema6_Tarea14_Integrador2
{
    internal class Program
    {
        const string Apuesta = "\nYa hay una apuesta realizada lista para ser comprobada.",
                     Texto = "\nDebe haber primero una apuesta generada.",
                     Titulo = "\nTema 6 - Tarea 14: Manuel MR ®\n" +
                              "══════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(Titulo);

            List<int> numSorteo = new(), apuestaManual = new(), apuestaAuto = new();
            int opcion;
            Random random = new();
            bool esManual = false, esAuto = false, esSorteo = false;

            do
            {
                opcion = LoteriaPrimitiva.Menu();

                switch (opcion)
                {
                    case 1:
                        if (!esSorteo)
                        {
                            LoteriaPrimitiva.GenerarNumeros(numSorteo, random);
                            esSorteo = true;
                            Console.WriteLine("\nSorteo generado de manera aleatoria.");
                        }
                        else
                        {
                            Console.WriteLine("\nYa hay un sorteo activo.");
                        }
                        break;
                    case 2:
                        if (!esAuto && !esManual)
                        {
                            LoteriaPrimitiva.LeerNumeros(apuestaManual);
                            esManual = true;
                        }
                        else
                        {
                            Console.WriteLine(Apuesta);
                        }
                        break;
                    case 3:
                        if (!esManual && !esAuto)
                        {
                            LoteriaPrimitiva.GenerarNumeros(apuestaAuto, random);
                            esAuto = true;
                            Console.WriteLine("\nApuesta generada de manera aleatoria.");
                        }
                        else
                        {
                            Console.WriteLine(Apuesta);
                        }
                        break;
                    case 4:
                        if (esManual && esSorteo)
                        {
                            Console.WriteLine($"\nEl número de aciertos de la lotería es: " +
                                              $"{LoteriaPrimitiva.ComprobarAciertos(numSorteo, apuestaManual)}");
                        }
                        else if (esAuto && esSorteo)
                        {
                            Console.WriteLine($"\nEl número de aciertos de la lotería es: " +
                                              $"{LoteriaPrimitiva.ComprobarAciertos(numSorteo, apuestaAuto)}");
                        }
                        else
                        {
                            Console.WriteLine(Texto);
                        }
                        break;
                    case 5:
                        if (esManual && esSorteo)
                        {
                            Console.WriteLine($"\nLos números del sorteo son:\n" +
                                              $"═>{LoteriaPrimitiva.MostrarApuestas(numSorteo)}\n" +
                                              $"\nLos números de la apuesta manual son:\n" +
                                              $"═>{LoteriaPrimitiva.MostrarApuestas(apuestaManual)}\n");
                            
                            esSorteo = false; esManual = false; esAuto = false;
                        }
                        else if (esAuto && esSorteo)
                        {
                            Console.WriteLine($"\nLos números del sorteo son:\n" +
                                              $"═>{LoteriaPrimitiva.MostrarApuestas(numSorteo)}\n" +
                                              $"\nLos números de la apuesta automática son:\n" +
                                              $"═>{LoteriaPrimitiva.MostrarApuestas(apuestaAuto)}\n");

                            esSorteo = false; esManual = false; esAuto = false;
                        }
                        else
                        {
                            Console.WriteLine(Texto);
                        }
                        break;
                }

                if (opcion != 6)
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

            } while (opcion != 6);

            Console.WriteLine("\n\nFin del programa." +
                              "\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
