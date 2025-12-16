namespace Tema4_Tarea15
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

        static bool EsBisiesto (int year)
        {
            bool esBisiesto = false;

            if ((year % 4 == 0 && year % 100 != 100) || year % 400 == 0)
            {
                esBisiesto = true;
            }

            return esBisiesto;
        }

        static bool EsFechaCorrecta (int dia, int mes, int year)
        {
            bool esFechaCorrecta = false;

            if ((mes >= 1 && mes <= 12) && (year >= 1 && year <= 3000))
            {
                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia >= 1 && dia <= 31)
                        {
                            esFechaCorrecta = true;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia >= 1 && dia <= 30)
                        {
                            esFechaCorrecta = true;
                        }
                        break;
                    case 2:
                        if (EsBisiesto(year))
                        {
                            if (dia >= 1 && dia <= 29)
                            {
                                esFechaCorrecta = true;
                            }
                        }
                        else if (dia >= 1 && dia <= 28)
                        {
                            esFechaCorrecta = true;
                        }    
                        break;
                }
            }

            return esFechaCorrecta;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 15: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int dia, mes, year;

            dia = LeerNumero("\nIntroduce el día: ");
            mes = LeerNumero("\nIntroduce el mes: ");
            year = LeerNumero("\nIntroduce el año: ");

            if (EsFechaCorrecta(dia, mes, year))
            {
                Console.WriteLine($"\n═> La fecha {dia}/{mes}/{year} es correcta.");
            }
            else
            {
                Console.WriteLine($"\n═> La fecha {dia}/{mes}/{year} no es correcta.");
            }
            
            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
