using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea04.Modelos
{
    public class Triangulo : Figura
    {
        private int _lado;

        public int Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }

        public Triangulo(int x, int y, string color, int lado) : base(x, y, color)
        {
            _lado = lado;
        }

        public override string QuienSoy()
        {
            return "soy un Triángulo.\n";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Lado: {Lado}";
        }

        public override double Area()
        {
            return ((double)Math.Sqrt(3) / 4) * (Lado * Lado);
        }

        public override double Perimetro()
        {
            return 3 * Lado;
        }
    }
}
