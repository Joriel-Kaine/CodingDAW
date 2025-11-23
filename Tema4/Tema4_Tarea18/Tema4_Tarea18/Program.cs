namespace Tema4_Tarea18
{
    internal class Program
    {
        static int LeerNumero (string mensaje)
        {
            int fecha;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out fecha);

                if (!esCorrecto)
                {
                    Console.WriteLine("\n\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return fecha;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 18: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int dia, mes, year;

            year = LeerNumero("\nIntroduce el año: ");
            mes = LeerNumero("\nIntroduce el mes: ");
            dia = LeerNumero("\nIntroduce el día: ");

            DateTime fechaEspecifica = new DateTime(year, mes, dia);
            DateTime diaSiguiente = fechaEspecifica.AddDays(1);

            Console.WriteLine($"\n═> La fecha introducida es {fechaEspecifica.ToString("d")} ");

            Console.WriteLine("\nPulsa una tecla para sumar 1 día a la fecha introducida.");
            Console.ReadKey();
            Console.WriteLine($"\n═> La nueva fecha es {diaSiguiente.ToString("d")}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
