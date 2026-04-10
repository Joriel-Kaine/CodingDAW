using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public class ListaProfesionales
    {
        private List<Profesional> _listaProfesionales = new();

        public void AddProfesional(Profesional profesional)
        {
            _listaProfesionales.Add(profesional);
        }
    }
}
