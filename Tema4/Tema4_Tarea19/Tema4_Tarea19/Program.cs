namespace Tema4_Tarea19
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

        static void SepararPesetas (ref int dinero, ref int diezMil, ref int cincoMil, ref int dosMil,
                                    ref int cien, ref int veintiCinco, ref int uno)
        {
            int aux = dinero;

            diezMil = aux / 10000;
            aux %= 10000;

            cincoMil = aux / 5000;
            aux %= 5000;

            dosMil = aux / 2000;
            aux %= 2000;

            cien = aux / 100;
            aux %= 100;
            
            veintiCinco = aux / 25;
            aux %= 25;
            
            uno = aux;
            aux = 0;
        }

        static string MostrarResultado(int diezMil, int cincoMil, int dosMil,
                                        int cien, int veintiCinco, int uno)
        {
            string mensaje;

            mensaje = (diezMil == 1)
                ? $"\n{diezMil} billete de 10.000 pesetas.\n"
                : $"\n{diezMil} billetes de 10.000 pesetas.\n";

            mensaje += $"\n{cincoMil} billete de 5.000 pesetas.\n";

            mensaje += (dosMil == 1)
                ? $"\n{dosMil} billete de 2.000 pesetas.\n"
                : $"\n{dosMil} billetes de 2.000 pesetas.\n";

            mensaje += (cien == 1)
                ? $"\n{cien} moneda de 100 pesetas.\n"
                : $"\n{cien} monedas de 100 pesetas.\n";

            mensaje += (veintiCinco == 1)
                ? $"\n{veintiCinco} moneda de 25 pesetas.\n"
                : $"\n{veintiCinco} monedas de 25 pesetas.\n";

            mensaje += (uno == 1)
                ? $"\n{uno} moneda de 1 peseta."
                : $"\n{uno} monedas de 1 peseta.";

            return mensaje;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 19: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            int dinero;
            int diezMil = 0, cincoMil = 0, dosMil = 0, cien = 0, veintiCinco = 0, uno = 0;

            dinero = LeerNumero("\nIntroduce la cantidad en pesetas: ");

            SepararPesetas(ref dinero, ref diezMil, ref cincoMil, ref dosMil, ref cien, ref veintiCinco, ref uno);

            Console.WriteLine(MostrarResultado(diezMil, cincoMil, dosMil, cien, veintiCinco, uno));

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
