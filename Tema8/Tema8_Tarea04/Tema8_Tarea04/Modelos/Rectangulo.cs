using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea04.Modelos
{
    public class Rectangulo : Figura
    {
        private int _ancho;
        private int _alto;

        public int Ancho
        {
            get { return _ancho; }
            set { _ancho = value; }
        }

        public int Alto
        {
            get { return _alto; }
            set { _alto = value; }
        }

        public Rectangulo(int x, int y, string color, int alto, int ancho) : base(x, y, color)
        {
            _ancho = ancho;
            _alto = alto;
        }

        public override string QuienSoy()
        {
            return "Soy un Rectángulo.\n";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Ancho: {Ancho}" +
                   $"Alto: {Alto}";
        }

        public override double Area()
        {
            return Ancho * Alto;
        }

        public override double Perimetro()
        {
            return 2 * (Ancho + Alto);
        }
    }
}
