using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6_Tarea13
{
    public class OperacionesList
    {
        private static List<string> InsertarOrdenado(ref string palabra)
        {
            int pos;
            List<string> lista = new();

            lista.Add(palabra);
            
            lista.Insert(palabra);
        }

        public static string GestionarListaPalabras()
        {

        }
    }
}
