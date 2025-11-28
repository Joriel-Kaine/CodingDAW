namespace Tema4_Tarea20
{
    internal class Program
    {
        static int LeerNumero(string mensaje)
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

        static void CalcularBilletes(ref int cantidadEuros, ref int cantidadCentimos,
                                    ref string texto, int tipoBillete)
        {
            int numBillete;

            if (cantidadEuros >= tipoBillete && cantidadEuros < 5)
            {
                numBillete = cantidadEuros / tipoBillete;

                texto += $"{numBillete} billetes de {tipoBillete} euros.";

                cantidadEuros %= tipoBillete;
            }
            else if (cantidadEuros >= tipoBillete && cantidadEuros > 1)
            {
                numBillete = cantidadEuros / tipoBillete;

                texto += $"{numBillete} monedas de {tipoBillete} euros.";

                cantidadEuros %= tipoBillete;
            }
            else if (cantidadEuros >= tipoBillete && cantidadEuros == 1)
            {
                cantidadCentimos = cantidadEuros * 100;
                cantidadEuros--;
            }
        }

        static void CalcularMonedas(ref int cantidadCentimos, ref string texto, int tipoMoneda)
        {
            int numMoneda;

            if (cantidadCentimos >= tipoMoneda && cantidadCentimos == 2)
            {
                numMoneda = cantidadCentimos / tipoMoneda;

                texto += $"{numMoneda} monedas de {tipoMoneda} euros.";
            }
        }

        static string ObtenerTextoEuros(decimal cantidadDinero)
        {
            string texto = "";
            int cantidadEuros = (int)Math.Floor(cantidadDinero);
            int cantidadCentimos = (int)(cantidadDinero * 100 - cantidadEuros * 100);

            CalcularBilletes(ref cantidadEuros, ref texto, 500);
            CalcularBilletes(ref cantidadEuros, ref texto, 200);
            CalcularBilletes(ref cantidadEuros, ref texto, 50);
            CalcularBilletes(ref cantidadEuros, ref texto, 20);
            CalcularBilletes(ref cantidadEuros, ref texto, 5);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 20: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");



            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
