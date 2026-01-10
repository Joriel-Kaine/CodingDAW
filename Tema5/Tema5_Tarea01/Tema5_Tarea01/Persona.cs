using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5_Tarea01
{
    public class Persona
    {
        private string _nombre;
        private int _edad;
        private string _telefono;
        private string _sexo;
        private bool _casado;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set 
            {
                if (_edad >= 0 || _edad <= 100)
                {
                    _edad = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("\nLa edad debe estar entre 0 y 100");
                }
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public bool Casado
        {
            get { return _casado; }
            set { _casado = value; }
        }
    }
}
