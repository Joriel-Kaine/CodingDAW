using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Tarea17
{
    public class Alternativa
    {
        static bool EsBisiesto(int year)
        {
            bool esCorrecto = false;

            if ((year % 4 == 0 && year % 100 != 100) || year % 400 == 0)
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public static void DiaSiguiente(ref int dia, ref int mes, ref int year)
        {
            if (dia < 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            {
                dia++;
            }
            else if (EsBisiesto(year) && dia < 29 && mes == 2)
            {
                dia++;
            }
            else if (!EsBisiesto(year) && dia < 28 && mes == 2)
            {
                dia++;
            }
            else if (dia < 31)
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
    }
}
