using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea02
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


        // Constructores. Llama al constructor de Figura.
        public Circulo(int x, int y, string color, int radio) : base(x, y, color)
        {
            _radio = radio;
        }


        // Métodos.

        // Sobreescritura del método virtual.
        public override string QuienSoy()
        {
            return "Soy un círculo.\n";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Radio: {Radio}";
        }

        public override double Area()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
