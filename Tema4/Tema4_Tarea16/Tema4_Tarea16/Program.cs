namespace Tema4_Tarea16
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
                    Console.WriteLine("\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static bool EsHoraCorrecta (int hora, int minuto, int segundo)
        {
            bool esCorrecto = false;

            if ((hora >= 0 && hora <= 23) &&
                (minuto >= 0 && minuto <= 59) &&
                (segundo >= 0 && segundo <= 59))
            {
                esCorrecto = true;
            }
            
            return esCorrecto;
        }

        static void HoraSiguiente (ref int hora, ref int minuto, ref int segundo)
        {
            if (segundo < 59)
            {
                segundo++;
            }
            else
            {
                minuto++;
                segundo = 0;

                if (minuto == 60)
                {
                    hora++;
                    minuto = 0;

                    if (hora == 24)
                    {
                        hora = 0;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 16: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int hora, minuto, segundo;
            bool esCorrecto;

            do
            {
                hora = LeerNumero("\nIntroduce las horas: ");
                minuto = LeerNumero("\nIntroduce los minutos: ");
                segundo = LeerNumero("\nIntroduce los segundos: ");

                esCorrecto = EsHoraCorrecta(hora, minuto, segundo);

                if (!esCorrecto)
                {
                    Console.WriteLine($"\n═> La hora {hora:D2}:{minuto:D2}:{segundo:D2} introducida no es correcta.\n" +
                                      $"═> Pulsa una tecla para volver a introducir la hora.");
                    Console.ReadKey();
                }

            } while (!esCorrecto);

            Console.WriteLine($"\n═> La hora introducida es: {hora:D2}:{minuto:D2}:{segundo:D2}");
            Console.WriteLine("\nPulsa una tecla para sumar 1 segundo a la hora.");
            Console.ReadKey();

            HoraSiguiente(ref hora, ref minuto, ref segundo);

            Console.WriteLine($"\n═> La nueva hora es: {hora:D2}:{minuto:D2}:{segundo:D2}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
