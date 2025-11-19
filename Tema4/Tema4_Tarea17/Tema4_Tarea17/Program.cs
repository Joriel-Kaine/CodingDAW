namespace Tema4_Tarea17
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
                    Console.WriteLine("\n\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static bool EsBisiesto (int year)
        {
            bool esCorrecto = false;

            if ((year % 4 == 0 && year % 100 != 100) && year % 400 == 0)
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        static bool EsFechaCorrecta (int dia, int mes, int year)
        {
            bool esCorrecto = false;

            if ((mes >= 1 && mes <= 12) && year >= 0)
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
                            esCorrecto = true;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia >= 1 && dia <= 30)
                        {
                            esCorrecto = true;
                        }
                        break;
                    case 2:
                        if (EsBisiesto(year))
                        {
                            if (dia >= 1 && dia <= 29)
                            {
                                esCorrecto = true;
                            }
                            else if (dia >= 1 && dia <= 28)
                            {
                                esCorrecto = true;
                            }
                        }
                        break;
                }
            }

            return esCorrecto;
        }

        static void DiaSiguiente (ref int dia, ref int mes, ref int year)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 17: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int dia, mes, year;

            dia = LeerNumero("Introduce el día: ");
            mes = LeerNumero("\nIntroduce el mes: ");
            year = LeerNumero("\nIntroduce el año: ");

            if (EsFechaCorrecta(dia, mes, year))
            {

            }
            else
            {
                Console.WriteLine("\n\nIntroduce una fecha correcta.");
            }
            
            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
