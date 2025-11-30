namespace Tema4_Tarea17b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Comprobamos si el mes de febrero es bisiesto o no, según el año.
        bool EsBisiesto (int year)
        {
            bool esCorrecto = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        // Hacemos una comprobación de que la fecha sea correcta. Día, mes y año son válidos.
        bool EsFechaCorrecta (int dia, int mes, int year)
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
        int DiaEnMes (int mes, int year)
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
        void DiaSiguiente (ref int dia, ref int mes, ref int year)
        {
            if (dia < DiaEnMes(mes, year))
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

        // En este botón comprobamos si la fecha introducida es valida o correcta.
        private void btnFecha_Click(object sender, EventArgs e)
        {
            int dia, mes, year;
            bool esCorrecto1, esCorrecto2, esCorrecto3;

            esCorrecto1 = int.TryParse(txtDia.Text, out dia);
            esCorrecto2 = int.TryParse(txtMes.Text, out mes);
            esCorrecto3 = int.TryParse(txtYear.Text, out year);

            // Aquí hacemos un if para que se introduzca la fecha correcta o válida.
            if (esCorrecto1 && esCorrecto2 && esCorrecto3)
            {
                if (!EsFechaCorrecta(dia, mes, year))
                {
                    // Usamos :D2 para que sean siempre dos dígitos.
                    lblFecha.Text = $"La fecha {dia:D2}/{mes:D2}/{year:D2} no es correcta.";
                }
                else
                {
                    lblFecha.Text = $"La fecha {dia:D2}/{mes:D2}/{year:D2} es correcta.";
                }
            }
            else
            {
                MessageBox.Show("Introduce valores numéricos válidos.", "Error de formato");
            }
        }

        // En este botón añadimos un día siempre que la fecha sea correcta.
        private void btnDiaSiguiente_Click(object sender, EventArgs e)
        {
            int dia, mes, year;
            bool esCorrecto1, esCorrecto2, esCorrecto3;

            esCorrecto1 = int.TryParse(txtDia.Text, out dia);
            esCorrecto2 = int.TryParse(txtMes.Text, out mes);
            esCorrecto3 = int.TryParse(txtYear.Text, out year);

            if (esCorrecto1 && esCorrecto2 && esCorrecto3)
            {
                if (EsFechaCorrecta(dia, mes, year))
                {
                    /*
                     * Se introduce la fecha del día siguiente, usando ref para que tanto día, mes,
                     * año se actualicen a la nueva fecha.
                     */
                    DiaSiguiente(ref dia, ref mes, ref year);

                    lblDiaSiguiente.Text = $"La nueva fecha es {dia:D2}/{mes:D2}/{year:D2}";
                }
            }
            else
            {
                MessageBox.Show("Introduce valores numéricos válidos.", "Error de formato");
            }
        }

        // Este botón es para limpiar todo y volver a introducir datos.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDia.Clear();
            txtMes.Clear();
            txtYear.Clear();
            txtDia.Focus();
            lblFecha.Text = "";
            lblDiaSiguiente.Text = "";
        }
    }
}
