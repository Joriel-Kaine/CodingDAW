namespace Tema4_Tarea17
{
    internal class Program
    {

        // Comprobamos que la entrada es correcta.
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
                    Console.WriteLine("\n═> Introduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        // Comprobamos si el mes de febrero es bisiesto o no, según el año.
        static bool EsBisiesto (int year)
        {
            bool esCorrecto = false;

            if ((year % 4 == 0 && year % 100 != 100) || year % 400 == 0)
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        // Hacemos una comprobación de que la fecha sea correcta. Día, mes y año son válidos.
        static bool EsFechaCorrecta (int dia, int mes, int year)
        {
            bool esCorrecto = false;

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
                        }
                        else if (dia >= 1 && dia <= 28)
                        {
                            esCorrecto = true;
                        }
                        break;
                }
            }

            return esCorrecto;
        }

        // Hacemos un switch/case para separar los meses de 31, 30, o el mes de febrero.
        static int DiasEnMes(int mes, int year)
        {
            int dia = 0;

            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dia = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dia = 30;
                    break;
                case 2:
                    if (EsBisiesto(year))
                    {
                        dia = 29;
                    }
                    else
                    {
                        dia = 28;
                    }
                    break;
            }

            return dia;
        }

        /*
         * Añadimos un día a la fecha, teniendo en cuenta los diferentes casos.
         * Si el día era 31, hay que controlar que el siguiente no sea 32, si no 1 del mes siguiente.
         * Lo mismo con el mes. Si es mes 12, no vamos al 13 si no al 1 del siguiente año.
         */
        static void DiaSiguiente (ref int dia, ref int mes, ref int year)
        {
            if (dia < DiasEnMes(mes, year))
            {
                dia++;
            }
            else
            {
                mes++;
                dia = 1;

                if (mes == 13)
                {
                    year++;
                    mes = 1;
                }
            }
        }

        const string titulo = "\nTema 4 - Tarea 17: Manuel MR ®\n" +
                              "══════════════════════════════\n\n";

        static void Main(string[] args)
        {
            Console.WriteLine(titulo);

            int dia, mes, year;
            bool esCorrecto;

            // Aquí hacemos un bucle para que se siga introduciendo la fecha hasta que sea correcta.
            do
            {
                dia = LeerNumero("\nIntroduce el día: ");
                mes = LeerNumero("\nIntroduce el mes: ");
                year = LeerNumero("\nIntroduce el año: ");

                esCorrecto = EsFechaCorrecta(dia, mes, year);

                if (!esCorrecto)
                {
                    // Usamos :D2 para que sean siempre dos dígitos.
                    Console.WriteLine($"\n═> La fecha {dia:D2}/{mes:D2}/{year:D2} introducida no es correcta.");
                    Console.WriteLine("\nIntroduce una fecha correcta.");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine(titulo);
                }

            } while (!esCorrecto);

            Console.WriteLine($"\n═> La fecha {dia:D2}/{mes:D2}/{year:D2} es correcta.");
            Console.WriteLine("\nPulsa una tecla para sumar 1 día a la fecha introducida.");
            Console.ReadKey();

            // Se introduce la fecha del día siguiente, usando ref para que tanto día, mes, año se actualicen a la nueva fecha.
            DiaSiguiente(ref dia, ref mes, ref year);

            Console.WriteLine($"\n\n═> La nueva fecha es {dia:D2}/{mes:D2}/{year:D2}");
            
            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
