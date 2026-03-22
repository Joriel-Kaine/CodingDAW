using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema8_Tarea02.Base;
using Tema8_Tarea02.Interfaz;

namespace Tema8_Tarea02.Listas
{
    public class ListaFiguras
    {
        // Declaración de lista donde meter TODAS las figuras.
        private List<Figura> _listaFiguras = new();


        public void AddFigura(Figura figura)
        {
            _listaFiguras.Add(figura);
        }
    }
}
