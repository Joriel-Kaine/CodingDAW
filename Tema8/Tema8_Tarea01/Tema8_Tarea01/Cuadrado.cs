using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea01
{
    public class Cuadrado : Figura
    {
        // Campos.
        private int _area;

        // Propiedades.
        public int Area
        {
            get { return _area; }
            set { _area = value; }
        }

        // Constructores.
        public Cuadrado(int x, int y, string color, int area) : base(x, y, color)
        {
            _area = area;
        }

        // Métodos.
    }
}
