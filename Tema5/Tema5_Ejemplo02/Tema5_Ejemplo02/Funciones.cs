using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5_Ejemplo02
{
    public class Funciones
    {
        private static int NumMenor(int n1, int n2)
        {
            int menor;

            return menor = (n1 < n2) ? n1 : n2;
        }

        // Función que obtiene el máximo común divisor.
        // Empezamos desde 1 y vamos subiendo hasta el número menor de los dos.
        // Nos quedamos con el último número que divide a ambos.
        public static int CalcularMCD(int n1, int n2)
        {
            int mcd = 0, menor = NumMenor(n1, n2);

            for (int i = 1; i <= menor; i++)
            {
                // Si el número es divisor de ambos pasa a ser el MCD.
                if (n1 % i == 0 && n2 % i == 0)
                {
                    mcd = i;
                }
            }

            return mcd;
        }

        public static int Potencia(int bbase, int exponente)
        {
            int potencia = 1;

            for (int i = 1; i <= exponente; i++)
            {
                potencia *= bbase;
            }

            return potencia;
        }
    }
}
