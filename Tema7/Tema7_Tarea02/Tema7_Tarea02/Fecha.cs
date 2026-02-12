using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea02
{
    public class Fecha
    {
        // Miembros.
        private int _dia;
        private int _mes;
        private int _year;
        
        // Propiedades.
        public int Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        public int Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Constructores.
        public Fecha()
        {
            _dia = -1;
            _mes = -1;
            _year = -1;
        }

        public Fecha (int dia, int mes, int year)
        {
            Dia = dia;
            Mes = mes;
            Year = year;
        }

        // Métodos de la clase Fecha.
        private bool EsBisiesto()
        {
            bool esBisiesto = false;

            if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
            {
                esBisiesto = true;
            }

            return esBisiesto;
        }

        private bool EsYearCorrecto()
        {
            bool esCorrecto = false;

            if (Year > 0 && Year < 2082)
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        private bool EsMesCorrecto()
        {
            bool esCorrecto = false;

            if (Mes >= 1 && Mes <= 12)
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        private int DiasEnMes()
        {
            int dias = 0;

            switch (Mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dias = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dias = 30;
                    break;
                case 2:
                    if (!EsBisiesto())
                    {
                        dias = 28;
                    }
                    else
                    {
                        dias = 29;
                    }
                    break;
            }

            return dias;
        }

        public bool EsFechaValida()
        {
            bool esValida = false;

            if (EsYearCorrecto() && EsMesCorrecto() && (Dia >= 1 && Dia <= DiasEnMes()))
            {
                esValida = true;
            }

            return esValida;
        }

        public bool EsFechaMasActual(Fecha otraFecha)
        {
            bool esMasActual = false;

            if ((Year > otraFecha.Year) ||
                (Year == otraFecha.Year && Mes > otraFecha.Mes) ||
                (Year == otraFecha.Year && Mes == otraFecha.Mes && Dia > otraFecha.Dia))
            {
                esMasActual = true;
            }

            return esMasActual;
        }

        public string MostrarFecha()
        {
            return $"{Dia:D2}/{Mes:D2}/{Year}";
        }
    }
}
