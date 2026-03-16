using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea01
{
    public class Circulo : Figura
    {
        // Campos.
        private int _radio;


        // Propiedades.
        public int Radio
        {
            get { return _radio; }
            set { _radio = value; }
        }


        // Constructores.
        public Circulo(int x, int y, string color, int radio) : base(x, y, color)
        {
            _radio = radio;
        }


        // Métodos.
    }
}
