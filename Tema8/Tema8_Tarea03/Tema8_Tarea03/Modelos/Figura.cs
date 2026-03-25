using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea03.Modelos
{
    public abstract class Figura
    {
        private int _posicionX;
        private int _posicionY;
        private string _color;


        public int PosicionX
        {
            get { return _posicionX; }
            set { _posicionX = value; }
        }

        public int PosicionY
        {
            get { return _posicionY; }
            set { _posicionY = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }


        public Figura(int x, int y, string color)
        {
            _posicionX = x;
            _posicionY = y;
            _color = color;
        }


        // Método virtual. Se puede reescribir en las clases que heredan.
        public virtual string QuienSoy()
        {
            return "Soy una figura.";
        }

        // Sobreescritura de un método que heredamos de System.Object
        public override string ToString()
        {
            return $"Posición X: {PosicionX}\n" +
                   $"Posición Y: {PosicionY}\n" +
                   $"Color: {Color}";
        }

        // Método abastracto. No tiene cuerpo. Se reescribe en las clases que heredan.
        public abstract double Area();

        public string GenerarTextoFigura()
        {
            return $"{QuienSoy()}\n" +
                   $"{ToString()}\n" +
                   $"Mi área es {Area()}";
        }
    }
}
