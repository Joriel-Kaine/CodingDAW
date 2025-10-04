using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Tarea10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 + 3 * 5); // Resultado: 17.

            Console.WriteLine((2 + 3) * 5); // Resultado: 25.

            Console.WriteLine((5 + 2) == 7 && (3 > 1)); // Resultado: true.

            Console.WriteLine((5 + 2) == 7 || (3 < 1)); // Resultado: true.

            Console.WriteLine((!true) || (false && true)); // Resultado: false.

            Console.WriteLine(10 / 3); // Resultado: 3.

            Console.WriteLine((1 + 2 * 3) == 7 || (4 % 2) == 0); // Resultado: true.
        }
    }
}
