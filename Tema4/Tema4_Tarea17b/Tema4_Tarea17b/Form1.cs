namespace Tema4_Tarea17b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool EsBisiesto (int year)
        {
            bool esCorrecto = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

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

        private void btnFecha_Click(object sender, EventArgs e)
        {
            int dia, mes, year;
            bool esCorrecto1, esCorrecto2, esCorrecto3;

            esCorrecto1 = int.TryParse(txtDia.Text, out dia);
            esCorrecto2 = int.TryParse(txtMes.Text, out mes);
            esCorrecto3 = int.TryParse(txtYear.Text, out year);

            if (esCorrecto1 && esCorrecto2 && esCorrecto3)
            {
                if (!EsFechaCorrecta(dia, mes, year))
                {
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
                    DiaSiguiente(ref dia, ref mes, ref year);

                    lblDiaSiguiente.Text = $"La nueva fecha es {dia:D2}/{mes:D2}/{year:D2}";
                }
            }
            else
            {
                MessageBox.Show("Introduce valores numéricos válidos.", "Error de formato");
            }
        }

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
