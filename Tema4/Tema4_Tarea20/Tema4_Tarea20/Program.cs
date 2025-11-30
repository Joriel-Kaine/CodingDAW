namespace Tema4_Tarea20
{
    internal class Program
    {
        // Comprobamos que el valor sea correcto.
        static decimal LeerNumero(string mensaje)
        {
            decimal num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = decimal.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\n\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        // Aquí hacemos la comprobación de si la cantidad es 1 o más. (Esta función fue con mucha ayuda de la IA)
        static string EuroSingularPlural(int cantidad, string singular, string plural)
        {
            string resultado;

            // Usamos una ternaria ya que es un if/else con una sola salida.
            return resultado = cantidad == 1 ? singular : plural;

        }

        /*
         * En esta función vamos a hacer toda la lógica de los distintos billetes y monedas de euro.
         * En la entrada tenemos que usar ref tanto en cantidadEuros como en texto porque queremos
         * mostrar los nuevos valores en cada vuelta.
         * Hacemos la lógica con los billetes y concatenamos el texto.
         */
        static void CalcularBilletes(ref int cantidadEuros, ref string texto, int tipoBillete)
        {
            int numBillete;

            if (cantidadEuros >= tipoBillete && cantidadEuros >= 5)
            {
                numBillete = cantidadEuros / tipoBillete;

                texto += $"\n{numBillete} {EuroSingularPlural(numBillete, "billete", "billetes")} de {tipoBillete} euros.";

                cantidadEuros %= tipoBillete;
            }
            else if (cantidadEuros >= tipoBillete && cantidadEuros > 1)
            {
                numBillete = cantidadEuros / tipoBillete;

                texto += $"\n{numBillete} {EuroSingularPlural(numBillete, "moneda", "monedas")} de {tipoBillete} euros.";

                cantidadEuros %= tipoBillete;
            }
        }

        // Misma operación con las monedas de céntimo.
        static void CalcularMonedas(ref int cantidadCentimos, ref string texto, int tipoMoneda)
        {
            int numMoneda;

            if (cantidadCentimos >= tipoMoneda && cantidadCentimos > 1)
            {
                numMoneda = cantidadCentimos / tipoMoneda;

                texto += $"\n{numMoneda} {EuroSingularPlural(numMoneda, "moneda", "monedas")} de {tipoMoneda} céntimos de euro.";

                cantidadCentimos %= tipoMoneda;
            }
            else if (cantidadCentimos == 1)
            {
                texto += $"\n\nSobra {cantidadCentimos} céntimo de euro.";
            }
        }

        // En esta función vamos a crear los textos que saldrán por pantalla uno a uno.
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
            CalcularBilletes(ref cantidadEuros, ref texto, 2);
            if (cantidadEuros == 1)
            {
                cantidadCentimos += cantidadEuros * 100;
                cantidadEuros--;
            }
            CalcularMonedas(ref cantidadCentimos, ref texto, 50);
            CalcularMonedas(ref cantidadCentimos, ref texto, 20);
            CalcularMonedas(ref cantidadCentimos, ref texto, 10);
            CalcularMonedas(ref cantidadCentimos, ref texto, 5);
            CalcularMonedas(ref cantidadCentimos, ref texto, 2);
            CalcularMonedas(ref cantidadCentimos, ref texto, 1);

            return texto;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTema 4 - Tarea 20: Manuel MR ®\n" +
                              "══════════════════════════════\n\n");

            decimal cantidad;

            cantidad = LeerNumero("\nIntroduce una cantidad de euros: ");

            Console.WriteLine(ObtenerTextoEuros(cantidad));

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
