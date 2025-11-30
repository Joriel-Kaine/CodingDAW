namespace Tema4_Tarea20b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                texto += $"{numBillete} {EuroSingularPlural(numBillete, "billete", "billetes")} de {tipoBillete} euros.\n";

                cantidadEuros %= tipoBillete;
            }
            else if (cantidadEuros >= tipoBillete && cantidadEuros > 1)
            {
                numBillete = cantidadEuros / tipoBillete;

                texto += $"{numBillete} {EuroSingularPlural(numBillete, "moneda", "monedas")} de {tipoBillete} euros.\n";

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

                texto += $"{numMoneda} {EuroSingularPlural(numMoneda, "moneda", "monedas")} de {tipoMoneda} céntimos de euro.\n";

                cantidadCentimos %= tipoMoneda;
            }
            else if (cantidadCentimos == 1)
            {
                texto += $"\nSobra {cantidadCentimos} céntimo de euro.";
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            decimal cantidad;
            bool esCorrecto;

            esCorrecto = decimal.TryParse(txtCantidad.Text, out cantidad);

            if (esCorrecto)
            {
                lblResultado.Text = ObtenerTextoEuros(cantidad);
            }
            else
            {
                MessageBox.Show("Introduce valores numéricos válidos.", "Error de formato");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtCantidad.Focus();
            lblResultado.Text = "";
        }
    }
}
