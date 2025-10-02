using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10; // num1 vale 10.
            int num2 = 20; // num2 vale 20.
            int num3 = num1 + num2; // num3 vale la suma de 10 + 20. Su valor es 30.
            num3 = num3 + 1; // num3 vale ahora 30 + 1. Su valor es 31.
            num3++; // num3 ahora vale 32 (se le suma 1).


            double r1 = num1 / num2; /* r1 vale 0. Al dividir 10 / 20 como números enteros,
                                      * el resultado es 0. */
            r1 = (double)num1 / (double)num2; /* r1 vale 0,5. La razón es que se han tratado como reales los
                                               * números anteriormente enteros. */
            double r2 = 2.0; // r2 tiene un valor real de 2,0.
            double r3 = r2 / r1 - 1; // r3 vale 3,0. Se divide 2,0 / 0,5 (da 4,0) y se le resta 1.
            r3 = r2 / (r1 - 1); /* r3 vale -4. La razón es porque primero se ha hecho la resta de 0,5 - 1 (-0,5)
                                 * y luego se ha dividido 2,0 / -0,5. */


            bool l1 = num1 > num2; // booleano falso (num1 no mayor que num2).
            l1 = (num1 > num2) && (num2 <= 20); // booleano falso. Usa (and) y una es falsa.
            l1 = (num1 > num2) || (num2 <= 20); // booleano veradero. Usar (or) y una de las dos es verdadera.
            l1 = (num1 < num2) || (num2 <= 20) && (num1 == 10); /* booleano verdadero. Primero se hace el (and) que son los dos
                                                                 * verdaderos y luego el (or) que uno de ellos es verdadero. */
            l1 = ((num1 < num2) || (num2 <= 20)) && (num1 != 10); /* booleano falso. Primero verdadero con (or) donde hay uno veradero
                                                                   * y el segundo es falso (and) porque hay uno falso. */
            l1 = !(((num1 < num2) || (num2 <= 20)) && (num1 != 10)); /* booleano verdadero. Primero verdadero (or).
                                                                      * Segundo falso (and). Tercero verdadero (not false). */
        }
    }
}
