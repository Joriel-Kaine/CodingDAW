using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea01
{
    public class Figura
    {
        // Campos.
        private int _posicionX;
        private int _posicionY;
        private string _color;


        //Propiedades.
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }


        // Constructores.
        public Figura(int x, int y, string color)
        {
            _posicionX = x;
            _posicionY = y;
            _color = color;
        }


        // Métodos.
    }
}
