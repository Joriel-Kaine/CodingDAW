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


        // Subprograma que devuelve posiciones x e y, y el color.
        public void ObtenerPosicionesColor(out int posX, out int posY, out string color)
        {
            posX = FuncionesInterfaz.LeerEntero("Introduce el valor de X:");
            posY = FuncionesInterfaz.LeerEntero("Introduce el valor de Y:");
            color = FuncionesInterfaz.LeerTexto("Introduce el color:");
        }
    }
}
