using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public abstract class Profesional
    {
        private string _nombre;
        private string _dni;
        private string _telefono;


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
    }
}
