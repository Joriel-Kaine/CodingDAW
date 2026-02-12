using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea02
{
    public class ListaFechas
    {
        // Miembros.
        private List<Fecha> _listaFechas;

        // Constructores.
        public ListaFechas()
        {
            _listaFechas = new();
        }

        // Métodos.
        public void AddListaFechas(Fecha fecha)
        {
            _listaFechas.Add(fecha);
        }

        public void OrdenarListaFechas()
        {
            Fecha aux;

            for (int i = 0; i < _listaFechas.Count - 1; i++)
            {
                for (int j = i + 1; j < _listaFechas.Count; j++)
                {
                    if (_listaFechas[i].EsFechaMasActual(_listaFechas[j]))
                    {
                        aux = _listaFechas[i];
                        _listaFechas[i] = _listaFechas[j];
                        _listaFechas[j] = aux;
                    }
                    
                }
            }
        }

        public string MostrarListaFechas()
        {
            string texto = "\nLista de fechas:\n";

            foreach (Fecha fecha in _listaFechas)
            {
                texto += $"{fecha.MostrarFecha()}\n";
            }

            return texto;
        }
    }
}
