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
            return base.QuienSoy();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override double Perimetro()
        {
            throw new NotImplementedException();
        }
    }
}
