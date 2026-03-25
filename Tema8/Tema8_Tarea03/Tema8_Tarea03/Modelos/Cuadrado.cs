using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea03.Modelos
{
    public class Cuadrado : Figura
    {
        // Campos.
        private int _lado;

        // Propiedades.
        public int Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }

        // Constructores. LLama al constructor de Figura.
        public Cuadrado(int x, int y, string color, int lado) : base(x, y, color)
        {
            Lado = lado;
        }

        // Métodos.

        // Sobreescritura del método virtual.
        public override string QuienSoy()
        {
            return "Soy un cuadrado.\n";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Lado: {Lado}";
        }

        public override double Area()
        {
            return Lado * Lado;
        }
    }
}
